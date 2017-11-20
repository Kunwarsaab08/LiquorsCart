using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LiquorsCart.ServerSide.Repository;
using LiquorsCart.ServerSide.Exceptions;
using LiquorsCart.ServerSide.Exceptions.BusinessExceptions;
using LiquorsCart.ServerSide.Exceptions.Mapper;
using DM = LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using VM = LiquorsCart.ServerSide.ViewModel.Inventory;
using AutoMapper;

namespace LiquorsCart.ServerSide.Service
{
    public class GenericService<TEntity> :Profile, IGenericService<TEntity> where TEntity : class
    {
        private UnitOfWork unitOfWork;
        public Type MapperDestinationType { get; set; }
        public Type GenRepo { get; set; }
        public dynamic GenRepoInstance { get; set; }

        private IMapper iMapper;

        public GenericService()
        {
            try
            {
                //Assign UOW object.
                unitOfWork = new UnitOfWork();

                ////Get details of View Model.
                //ViewModelClassName = typeof(TEntity).Name;
                //ViewModelNamespaceName = typeof(TEntity).Namespace;

                ////Get details of corresponding DataModel for a View Model.
                //DataModelTypeName = AppDomain.CurrentDomain.GetAssemblies()
                //           .SelectMany(t => t.GetTypes())
                //           .Where(t => t.IsClass
                //                && t.Name == ViewModelClassName
                //                && t.Namespace == ViewModelNamespaceName.Replace("ViewModel", "DataModel.DataModels"))
                //           .SingleOrDefault();                                          

                //Automapper Configuration for Testing for production need to register in Startup.cs
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<VM.SeoRepository, DM.SeoRepository>().ReverseMap();
                });

                iMapper = config.CreateMapper();
                
                //Getting all mappings from Automapper.
                var maps = config.GetAllTypeMaps();
                if(maps.Length > 0)
                {
                    foreach (var map in maps)
                    {
                        if (map.SourceType == typeof(TEntity))
                        {
                            MapperDestinationType = map.DestinationType;
                        }
                    }
                }  

                //If not found any destination tye in all mapper configuration.
                if(MapperDestinationType is null)
                {
                    throw new MappingNotFound("Automapper's mappings is not found for" + typeof(TEntity) + " .");
                }

                //Get Type of Generice Repository for Data Model instead of View Model.
                GenRepo = typeof(GenericRepository<>).MakeGenericType(MapperDestinationType);

                //Get Instance of Generic Repository for DataModel
                GenRepoInstance = Activator.CreateInstance(GenRepo, unitOfWork._context);
            }
            catch (Exception ex)
            {
                BusinessException businessException = new BusinessException();
                businessException.Data.Add("CustomException",
                    ex.Data["CustomException"] is null ? new CustomException(ex) :
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
                BusinessException businessException = new BusinessException();
                businessException.Data.Add("CustomException",
                    ex.Data["CustomException"] is null ? new CustomException(ex) :
                    ex.Data["CustomException"]);

                throw businessException;
            }
        }

        public List<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(object id)
        {
            //try
            //{
            //    //Create Instance of ViewModel
            //    var vmEntity = Activator.CreateInstance(typeof(TEntity));

            //    //Iterate through all the properties of View Model
            //    foreach (var property in vmEntity.GetType().GetProperties())
            //    {
            //        Console.WriteLine("{0}={1}", property.Name, property.GetValue(vmEntity, null));
            //    }
            //    //Getting GenericRepository's Generice Argument Type to cast DataModel.
            //    var dataModelType = GenRepoInstance.GetType().GetGenericArguments()[0];

            //    //Getting DataModel from View Model using Automapper.
            //    var dataModel = iMapper.Map(entity, entity.GetType(), DataModelTypeName);

            //    //Convert & Assign Data Model to proper type.
            //    dataModelType = dataModel;


            //    //Call GetById Method from Generic Repository for Data Model by Primary key 
            //    vmEntity = GenRepoInstance.GetById(id);

            //    //Commit changes to database.
            //    unitOfWork.Save();

            //    return vmEntity;
            //}
            //catch (Exception ex)
            //{
            //    BusinessException businessException = new BusinessException();
            //    businessException.Data.Add("CustomException",
            //        ex.Data["CustomException"] is null ? new CustomException(ex) :
            //        ex.Data["CustomException"]);

            //    throw businessException;
            //}
            throw new NotImplementedException();
        }

        public TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            try
            {
                //Getting GenericRepository's Generice Argument Type to cast DataModel.
                var dataModelType = GenRepoInstance.GetType().GetGenericArguments()[0];

                //Getting DataModel from View Model using Automapper.
                var dataModel = iMapper.Map(entity, entity.GetType(), MapperDestinationType);

                //Convert & Assign Data Model to proper type.
                dataModelType = dataModel;

                //Call Insert method of Generic Repository for Data Model.
                GenRepoInstance.Insert(dataModelType);

                //Commit changes to database.
                unitOfWork.Save();
            }
            catch (Exception ex)
            {
                BusinessException businessException = new BusinessException();
                businessException.Data.Add("CustomException",
                    ex.Data["CustomException"] is null ? new CustomException(ex) :
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
                //Getting GenericRepository's Generice Argument Type to cast DataModel.
                var dataModelType = GenRepoInstance.GetType().GetGenericArguments()[0];

                //Getting DataModel from View Model using Automapper.
                var dataModel = iMapper.Map(entity, entity.GetType(), MapperDestinationType);

                //Convert & Assign Data Model to proper type.
                dataModelType = dataModel;

                //Call Insert method of Generic Repository for Data Model.
                GenRepoInstance.Update(dataModelType);

                //Commit changes to database.
                unitOfWork.Save();
            }
            catch (Exception ex)
            {
                BusinessException businessException = new BusinessException();
                businessException.Data.Add("CustomException",
                    ex.Data["CustomException"] is null ? new CustomException(ex) :
                    ex.Data["CustomException"]);

                throw businessException;
            }
        }
    }
}
