using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using DataModel;
using DataModel.DataModels;

namespace Repository
{
    public class GenericDBcontext : DbContext
    {
        private static bool _created = false;
        public GenericDBcontext()
        {
            if (!_created)
            {
                Database.EnsureCreated();
                _created = true;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LiquorsCart;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public new DbSet<TEntity> Set<TEntity>() where TEntity : masterDM
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            var types = this.GetType().GetTypeInfo().Assembly.GetTypes()
                .Where(type => typeof(IEntityMappingConfiguration<>)
                .IsAssignableFrom(type));

            var method = typeof(ModelBuilder).GetMethods().First(m => m.Name == "Map"
                && m.IsGenericMethodDefinition
                && m.GetParameters().Length == 0);

            foreach (var type in types)
            {
                method = method.MakeGenericMethod(type);
                method.Invoke(modelBuilder, null);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
