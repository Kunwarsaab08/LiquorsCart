using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LiquorsCart.ServerSide.Repository
{
    public interface IGenericRepository<TEntity>
    {
        //Get all entities from DB
        //Parameters are filter, orderBy, includes
        List<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params Expression<Func<TEntity, object>>[] includes);

        //Get query for entity
        //Parameters are filter, orderBy
        IQueryable<TEntity> Query(
            Expression<Func<TEntity, bool>> filter = null, 
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);

        //Get single entity by id
        //Parameter is id
        TEntity GetById(object id);

        //Get first ot default entity by filter
        //Parameters are filter, includes
        TEntity GetFirstOrDefault(
            Expression<Func<TEntity, bool>> filter = null,
            params Expression<Func<TEntity, object>>[] includes);

        //Insert entity to DB
        //Parameter entity
        void Insert(TEntity entity);

        //Update entity in DB.
        //Parameter entity
        void Update(TEntity entity);

        //Delete entity from DB by id
        //Parameter id
        void Delete(object id);
    }
}
