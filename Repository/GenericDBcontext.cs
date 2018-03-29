using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using LiquorsCart.ServerSide.DataModel;

namespace LiquorsCart.ServerSide.Repository
{
    public class GenericDBcontext : DbContext
    {
        //To ensure one instance will serve all request from a client.
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

        public new DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Interface that all of our Entity maps implement
            var mappingInterface = typeof(IEntityMappingConfiguration<>);

            // Types that do entity mappingsss
            var mappingTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(t => t.GetTypes())
                .Where(x => x.GetInterfaces().Any(y => y.GetTypeInfo().IsGenericType && y.GetGenericTypeDefinition() == mappingInterface));

            // Get the generic Entity method of the ModelBuilder type
            var entityMethod = typeof(ModelBuilder).GetMethods()
                .SingleOrDefault(x => x.Name == "Entity" &&
                x.IsGenericMethod &&
                x.ReturnType.Name == "EntityTypeBuilder`1");

            foreach (var mappingType in mappingTypes)
            {
                // Get the type of entity to be mapped
                var genericTypeArg = mappingType.GetInterfaces().Single().GenericTypeArguments.Single();

                // Get the method builder.Entity<TEntity>
                var genericEntityMethod = entityMethod.MakeGenericMethod(genericTypeArg);

                // Invoke builder.Entity<TEntity> to get a builder for the entity to be mapped
                var entityBuilder = genericEntityMethod.Invoke(modelBuilder, null);

                // Create the mapping type and do the mapping
                var mapper = Activator.CreateInstance(mappingType);
                mapper.GetType().GetMethod("Map").Invoke(mapper, new[] { entityBuilder });
            }           
        }
    }
}
