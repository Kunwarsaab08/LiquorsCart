using System;
using AutoMapper;
using System.Linq;
using System.Reflection;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CustomExceptions = LiquorsCart.ServerSide.Exceptions;
using CustomRepository = LiquorsCart.ServerSide.Repository;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.Service
{
    public class GenericService<TEntity> :Profile, IGenericService<TEntity> where TEntity : class
    {
        private CustomRepository.UnitOfWork unitOfWork;
        public Type MapperDestinationType { get; set; }
        public Type GenRepo { get; set; }
        public dynamic GenRepoInstance { get; set; }
        
        public GenericService()
        {
            try
            {
                //Assign UOW object.
                unitOfWork = new CustomRepository.UnitOfWork();

                //Getting map from source type from Automapper.
                var map = Mapper.Configuration.GetAllTypeMaps()
                    .FirstOrDefault(t => t.SourceType == typeof(TEntity));

                //Getting destination type from retrieved map.
                MapperDestinationType = map.DestinationType;

                //If not found any destination tye in all mapper configuration.
                if (MapperDestinationType is null)
                {
                    throw new CustomExceptions.Mapper.MappingNotFound("Automapper's mappings is not found for" + typeof(TEntity) + " .");
                }

                //Get Type of Generice Repository for Data Model instead of View Model.
                GenRepo = typeof(CustomRepository.GenericRepository<>).MakeGenericType(MapperDestinationType);

                //Get Instance of Generic Repository for DataModel
                GenRepoInstance = Activator.CreateInstance(GenRepo, unitOfWork._context);
            }
            catch (Exception ex)
            {
                CustomExceptions.BusinessExceptions.BusinessException businessException = new CustomExceptions.BusinessExceptions.BusinessException();
                businessException.Data.Add("CustomException",
                    ex.Data["CustomException"] is null ? new CustomExceptions.CustomException(ex) :
                    ex.Data["CustomException"]);

                throw businessException;
            }            
        }

        public void Delete(object id)
        {
            try
            {
                //Call Delete Method from Generic Repository for Data Model by Primary key 
                GenRepoInstance.Delete(id);

                //Commit changes to database.
                unitOfWork.Save();
            }
            catch(Exception ex)
            {
                CustomExceptions.BusinessExceptions.BusinessException businessException = new CustomExceptions.BusinessExceptions.BusinessException();
                businessException.Data.Add("CustomException",
                    ex.Data["CustomException"] is null ? new CustomExceptions.CustomException(ex) :
                    ex.Data["CustomException"]);

                throw businessException;
            }
        }

        public List<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includes)
        {
            List<TEntity> listViewModel = new List<TEntity>();

            //Getting GenericRepository's Generice Argument Type to cast DataModel.
            var dataModelType = GenRepoInstance.GetType().GetGenericArguments()[0];

            //Call GetById Method from Generic Repository for Data Model by Primary key 
            dataModelType = GenRepoInstance.Get(filter, orderBy, includes);

            //// get all models (all properties)
            //List<Model> modelList = _unitOfWork.ModelRepository.Get(m => m.FirstName == "Jan" || m.LastName == "Holinka", includeProperties: "Account");

            //// get all models (some properties)
            //List<ModelDto> modelDtoList = _unitOfWork.UserRepository
            //    .Query(x => x.FirstName == "Jan" || x.LastName == "Holinka")
            //    .Select(x => new ModelDto
            //    {
            //        FirstName = x.FirstName,
            //        LastName = x.LastName
            //    })
            //    .ToList();

            return listViewModel;
        }

        public TEntity GetById(object id)
        {
            try
            {
                //Create Instance of ViewModel
                var vmEntity = Activator.CreateInstance(typeof(TEntity));
                
                //Getting GenericRepository's Generice Argument Type to cast DataModel.
                var dataModelType = GenRepoInstance.GetType().GetGenericArguments()[0];

                //Call GetById Method from Generic Repository for Data Model by Primary key 
                dataModelType = GenRepoInstance.GetById(id);

                //Getting ViewModel from Automapper 
                vmEntity = Mapper.Map(dataModelType, dataModelType.GetType(), typeof(TEntity));

                //Iterate through all the properties of View Model
                PropertyInfo[] propertyInfo = vmEntity.GetType().GetProperties();
                foreach (var property in propertyInfo)
                {
                    //Check wheather he property is of complex type.
                    if (property.PropertyType.Namespace != "System")
                    {
                        //Getting property's Destination Type from ViewModel's property type.
                        var propertyDestinationType = Mapper.Configuration.GetAllTypeMaps()
                                                .FirstOrDefault(t => t.SourceType == property.PropertyType).DestinationType;

                        //Getting property's Repository type for property's DataModel
                        Type propetyRepo = typeof(CustomRepository.GenericRepository<>).MakeGenericType(propertyDestinationType);

                        //Creating instance of property's Repository
                        dynamic propertyRepoInstance = Activator.CreateInstance(propetyRepo, unitOfWork._context);

                        //Getting Property's DM type from Generice Repo Instance.
                        var propertdataModelType = propertyRepoInstance.GetType().GetGenericArguments()[0];

                        //Getting value of corresponding property from respective DataModel
                        Type propertyTypeDM = dataModelType.GetType();
                        PropertyInfo propertyInfoDM = propertyTypeDM.GetProperty(property.Name);
                        var propertyValueDM = propertyInfoDM.GetValue(dataModelType, null);

                        //Get complete datamodel from Repo
                        propertdataModelType = propertyRepoInstance.GetById(propertyValueDM);

                        //Getting property view model.
                        var propertyViewModel= Mapper.Map(propertdataModelType, propertdataModelType.GetType(), property.PropertyType);
                        //var propertyViewModel = Mapper.Map<property.PropertyType>(propertdataModelType);

                        //Setting property View Model to Main/Returned view model.
                        vmEntity.GetType().GetProperty(property.Name).SetValue(vmEntity, Convert.ChangeType(propertyViewModel,property.PropertyType));
                    }
                }
                return (TEntity)vmEntity;
            }
            catch (Exception ex)
            {
                CustomExceptions.BusinessExceptions.BusinessException businessException = new CustomExceptions.BusinessExceptions.BusinessException();
                businessException.Data.Add("CustomException",
                    ex.Data["CustomException"] is null ? new CustomExceptions.CustomException(ex) :
                    ex.Data["CustomException"]);

                throw businessException;
            }            
        }

        public TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            try
            {
                //Getting GenericRepository's Generice Argument Type to cast Main DataModel.
                var dataModelType = GenRepoInstance.GetType().GetGenericArguments()[0];

                //Getting Main DataModel from Main View Model using Automapper.
                var dataModel = Mapper.Map(entity, entity.GetType(), MapperDestinationType);

                //Convert & Assign Data Model to proper type.
                dataModelType = dataModel;

                //Start Transaction
                unitOfWork.BeginTransaction(unitOfWork._context);

                //Iterate through all the properties of View Model with complex type
                var propertiesWithComplexTypes = entity.GetType().GetProperties()
                                                            .Where(prop=>prop.PropertyType.Namespace!= "System");

                foreach(var property in propertiesWithComplexTypes)
                {
                    //Getting property's Destination Type from ViewModel's property type.
                    Type propertyDestinationType = Mapper.Configuration.GetAllTypeMaps()
                                            .FirstOrDefault(t => t.SourceType == property.PropertyType).DestinationType;

                    //Getting DataModel from View Model using Automapper.
                    var propertyDataModel = Mapper.Map(property.GetValue(entity), property.PropertyType, propertyDestinationType);

                    //Getting property's Repository type for property's DataModel
                    Type propetyRepo = typeof(CustomRepository.GenericRepository<>).MakeGenericType(propertyDestinationType);

                    //Creating instance of property's Repository
                    dynamic propertyRepoInstance = Activator.CreateInstance(propetyRepo, unitOfWork._context);

                    //Getting Property's DM type from Generice Repo Instance.
                    var propertydataModelType = propertyRepoInstance
                                               .GetType()
                                               .GetGenericArguments()[0];

                    //Set paased entity to repo expected type.
                    propertydataModelType = propertyDataModel;

                    //check whether entity already exists or not
                    bool isExists = propertyRepoInstance.IsValidEntity(propertydataModelType);

                    //If entity is not exists then Insert else Update
                    if (!isExists)
                    {
                        propertyRepoInstance.Insert(propertydataModelType);
                    }
                    else
                    {
                        propertyRepoInstance.Update(propertydataModelType);
                    }

                    //Save the current complex property
                    unitOfWork.Save();

                    //Getting all the properties decorated with KeyAttribute of respective DataModel of View Model's Property
                    PropertyInfo propertyDMPropertiesWithDatabaseGeneratedAttribute = propertyDataModel
                                     .GetType()
                                     .GetProperties()
                                     .FirstOrDefault(prop => Attribute.IsDefined(prop, typeof(DatabaseGeneratedAttribute)));

                    //Getting value of corresponding property from respective DataModel
                    var propertyDMPropertyWithDatabaseGeneratedAttributeValueAfter = propertyDMPropertiesWithDatabaseGeneratedAttribute
                                                                                .GetValue(propertydataModelType, null);

                    //Setting property of Main Model
                    dataModelType.GetType().GetProperty(property.Name).SetValue(dataModelType, Convert.ChangeType(propertyDMPropertyWithDatabaseGeneratedAttributeValueAfter, propertyDMPropertyWithDatabaseGeneratedAttributeValueAfter.GetType()));
                }

                //Call Insert method of Generic Repository for Main Data Model.
                GenRepoInstance.Insert(dataModelType);

                //Commit changes to database.
                unitOfWork.Save();

                //Commit Transaction
                unitOfWork.CommitTransaction(unitOfWork._context);
            }
            catch (Exception ex)
            {
                //Rollback Transaction
                unitOfWork.RollBackTransaction(unitOfWork._context);

                CustomExceptions.BusinessExceptions.BusinessException businessException = new CustomExceptions.BusinessExceptions.BusinessException();
                businessException.Data.Add("CustomException",
                    ex.Data["CustomException"] is null ? new CustomExceptions.CustomException(ex) :
                    ex.Data["CustomException"]);

                throw businessException;
            }
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            try
            {
                //Getting GenericRepository's Generice Argument Type to cast Main DataModel.
                var dataModelType = GenRepoInstance.GetType().GetGenericArguments()[0];

                //Getting Main DataModel from Main View Model using Automapper.
                var dataModel = Mapper.Map(entity, entity.GetType(), MapperDestinationType);

                //Convert & Assign Data Model to proper type.
                dataModelType = dataModel;

                //Start Transaction
                unitOfWork.BeginTransaction(unitOfWork._context);

                //Iterate through all the properties of View Model with complex type
                var propertiesWithComplexTypes = entity.GetType().GetProperties()
                                                            .Where(prop => prop.PropertyType.Namespace != "System");

                foreach (var property in propertiesWithComplexTypes)
                {
                    //Getting property's Destination Type from ViewModel's property type.
                    Type propertyDestinationType = Mapper.Configuration.GetAllTypeMaps()
                                            .FirstOrDefault(t => t.SourceType == property.PropertyType).DestinationType;

                    //Getting DataModel from View Model using Automapper.
                    var propertyDataModel = Mapper.Map(property.GetValue(entity), property.PropertyType, propertyDestinationType);

                    //Getting property's Repository type for property's DataModel
                    Type propetyRepo = typeof(CustomRepository.GenericRepository<>).MakeGenericType(propertyDestinationType);

                    //Creating instance of property's Repository
                    dynamic propertyRepoInstance = Activator.CreateInstance(propetyRepo, unitOfWork._context);

                    //Getting Property's DM type from Generice Repo Instance.
                    var propertydataModelType = propertyRepoInstance
                                               .GetType()
                                               .GetGenericArguments()[0];

                    //Set paased entity to repo expected type.
                    propertydataModelType = propertyDataModel;

                    //check whether entity already exists or not
                    bool isExists = propertyRepoInstance.IsValidEntity(propertydataModelType);

                    //If entity is not exists then Insert else Update
                    if (!isExists)
                    {
                        propertyRepoInstance.Insert(propertydataModelType);
                    }
                    else
                    {
                        propertyRepoInstance.Update(propertydataModelType);
                    }

                    //Save the current complex property
                    unitOfWork.Save();

                    //Getting all the properties decorated with KeyAttribute of respective DataModel of View Model's Property
                    PropertyInfo propertyDMPropertiesWithDatabaseGeneratedAttribute = propertyDataModel
                                     .GetType()
                                     .GetProperties()
                                     .FirstOrDefault(prop => Attribute.IsDefined(prop, typeof(DatabaseGeneratedAttribute)));

                    //Getting value of corresponding property from respective DataModel
                    var propertyDMPropertyWithDatabaseGeneratedAttributeValueAfter = propertyDMPropertiesWithDatabaseGeneratedAttribute
                                                                                .GetValue(propertydataModelType, null);

                    //Setting property of Main Model
                    dataModelType.GetType().GetProperty(property.Name).SetValue(dataModelType, Convert.ChangeType(propertyDMPropertyWithDatabaseGeneratedAttributeValueAfter, propertyDMPropertyWithDatabaseGeneratedAttributeValueAfter.GetType()));
                }

                //Call Insert method of Generic Repository for Main Data Model.
                GenRepoInstance.Update(dataModelType);

                //Commit changes to database.
                unitOfWork.Save();

                //Commit Transaction
                unitOfWork.CommitTransaction(unitOfWork._context);
            }
            catch (Exception ex)
            {
                //Rollback Transaction
                unitOfWork.RollBackTransaction(unitOfWork._context);

                CustomExceptions.BusinessExceptions.BusinessException businessException = new CustomExceptions.BusinessExceptions.BusinessException();
                businessException.Data.Add("CustomException",
                    ex.Data["CustomException"] is null ? new CustomExceptions.CustomException(ex) :
                    ex.Data["CustomException"]);

                throw businessException;
            }
        }
    }
}
