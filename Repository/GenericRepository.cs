using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataModel.DataModels;
using System.Linq;

namespace Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : MasterDM, new()
    {
        private readonly DbContext _dbContext;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public GenericRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task Delete(T entity)
        {
            try
            { 
                _dbContext.Set<T>().Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception dbEx)
            {
                throw dbEx;
            }
        }

        public async Task Update(T entity)
        {
            try
            {
                _dbContext.Set<T>().Update(entity);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception dbEx)
            {
                throw dbEx;
            }            
        }

        public async Task Save(T entity)
        {
            try
            {
                _dbContext.Set<T>().Add(entity);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception dbEx)
            {
                throw dbEx;
            }            
        }

        public IEnumerable<T> FindAll()
        {
            try
            {
                return  _dbContext.Set<T>().ToList();
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
