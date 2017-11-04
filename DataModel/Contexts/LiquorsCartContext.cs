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
            
            //Inventory
            EntityMappingExtensions.RegisterEntityMapping<Category, CategoryMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<SubCategory, SubCategoryMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<TypeCategory, TypeCategoryMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<CategoryMappings, CategoryMappingMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<Company, CompanyMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<Brand, BrandMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<Product, ProductMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<ImageRepository, ImageRepositoryMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<SeoRepository, SeoRepositoryMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<ProductSKU, ProductSKUMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<Specification, SpecificationMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<SpecificationValue, SpecificationValuesMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<ProductSpecification, ProductSpecificationMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<ProductSKUInventory, ProductSKUInventoryMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<ProductSKUDiscount, ProductSKUDiscountMAP>(builder);

            //Vendor
            EntityMappingExtensions.RegisterEntityMapping<Vendor, VendorMAP>(builder);
            EntityMappingExtensions.RegisterEntityMapping<VendorSKU, VendorSKUInventoryMAP>(builder);
        }
    }
}
