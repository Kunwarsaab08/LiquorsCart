using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using DataModel.DataModels.Inventory;
using DataModel.DataModels.Vendor;
using DataModel.Mappings.Inventory;
using DataModel.Mappings.Vendor;

namespace DataModel.Contexts
{
    public partial class LiquorsCartContext : DbContext
    {
        //public DbSet<category> categories { get; set; }
        //public DbSet<subCategory> subcategories { get; set; }
        //public DbSet<typeCategory> typeCategories { get; set; }
        //public DbSet<categoryMappings> categoryMappings { get; set; }
        //public DbSet<company> companies { get; set; }
        //public DbSet<brand> brands { get; set; }
        //public DbSet<product> products { get; set; }
        //public DbSet<imageRepository> images { get; set; }
        //public DbSet<seoRepository> seos { get; set; }
        //public DbSet<productSKU> productSKUs { get; set; }
        //public DbSet<specification> specifications { get; set; }
        //public DbSet<specificationValue> specificationValues { get; set; }
        //public DbSet<productSpecification> productSpecifications { get; set; }
        //public DbSet<productSKUInventory> productSKUInventories { get; set; }
        //public DbSet<productSKUDiscount> productSKUDiscounts { get; set; }
        //public DbSet<vendor> vendors { get; set; }
        //public DbSet<vendorSKU> vvendorsSKUs { get; set; }

        private static bool _created = false;
        public LiquorsCartContext()
        {
            if (!_created)
            {
                Database.EnsureCreated();
                _created = true;
            }
        }
        

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;");            
        }       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            EntityMappingExtensions.RegisterEntityMapping<category, categoryMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<subCategory, subCategoryMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<typeCategory, typeCategoryMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<categoryMappings, categoryMappingMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<company, companyMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<brand, brandMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<product, productMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<imageRepository, imageRepositoryMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<seoRepository, seoRepositoryMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<productSKU, productSKUMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<specification, specificationMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<specificationValue, specificationValuesMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<productSpecification, productSpecificationValueMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<productSKUInventory, productSKUInventoryMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<productSKUDiscount, productSKUDiscountMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<vendor, vendorMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<vendorSKU, vendorSKUInventoryMAP>(builder);
        }
    }
}
