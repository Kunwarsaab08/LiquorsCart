using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LiquorsCart.ServerSide.Repository;
using LiquorsCart.ServerSide.Exceptions;
using LiquorsCart.ServerSide.Exceptions.BusinessExceptions;
using DM = LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using VM = LiquorsCart.ServerSide.ViewModel.Inventory;
using AutoMapper;

namespace LiquorsCart.ServerSide.Service
{
    public class GenericService<TEntity> :Profile, IGenericService<TEntity> where TEntity : class
    {
        private UnitOfWork unitOfWork;
        //private GenericRepository<TEntity> repo;

        public string ViewModelClassName { get; set; }
        public string ViewModelNamespaceName { get; set; }
        public Type DataModelTypeName { get; set; }
        public Type GenRepo { get; set; }
        public dynamic GenRepoInstance { get; set; }

        private IMapper iMapper;

        public GenericService()
        {
            try
            {
                //Assign UOW object.
                unitOfWork = new UnitOfWork();

                //Get details of View Model.
                ViewModelClassName = typeof(TEntity).Name;
                ViewModelNamespaceName = typeof(TEntity).Namespace;

                //Get details of corresponding DataModel for a View Model.
                DataModelTypeName = AppDomain.CurrentDomain.GetAssemblies()
                           .SelectMany(t => t.GetTypes())
                           .Where(t => t.IsClass
                                && t.Name == ViewModelClassName
                                && t.Namespace == ViewModelNamespaceName.Replace("ViewModel", "DataModel.DataModels"))
                           .SingleOrDefault();
                                
                //Get Type of Generice Repository for Data Model instead of View Model.
                GenRepo = typeof(GenericRepository<>).MakeGenericType(DataModelTypeName);
                
                //Get Instance of Generic Repository for DataModel
                GenRepoInstance = Activator.CreateInstance(GenRepo,unitOfWork._context);             

                //Automapper Configuration for Testing for production need to register in Startup.cs
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<VM.SeoRepository, DM.SeoRepository>().ReverseMap();
                });

                iMapper = config.CreateMapper();
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
                var dataModel = iMapper.Map(entity, entity.GetType(), DataModelTypeName);

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
                var dataModel = iMapper.Map(entity, entity.GetType(), DataModelTypeName);

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
