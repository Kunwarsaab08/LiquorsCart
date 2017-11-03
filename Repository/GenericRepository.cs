using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataModel.DataModels;
using System.Linq;

namespace Repository
{
    public class GenericRepository<T> where T : masterDM
    {
        private readonly DbContext _dbContext;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public GenericRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public T GetById(object id)
        {
            return this.Entities.Find(id);
        }

        public void Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.Entities.Add(entity);
                this._dbContext.SaveChanges();
            }
            catch (Exception dbEx)
            {
                throw dbEx;
            }
        }

        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this._dbContext.SaveChanges();
            }
            catch (Exception dbEx)
            {
                throw dbEx;
            }
        }

        public void Delete(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                this.Entities.Remove(entity);
                this._dbContext.SaveChanges();
            }
            catch (Exception dbEx)
            {
                throw dbEx;
            }
        }

        public virtual IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }

        private DbSet<T> Entities
        {
            get
            {
                if (entities == null)
                {
                    entities = _dbContext.Set<T>();
                }
                return entities;
            }
        }
    }
}
