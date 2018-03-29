------------------------------
--Database
------------------------------
--create database LiquorsCart;

------------------------------
--ImageRepository
------------------------------
Create table ImageRepository(ImageId bigint Identity(1,1) Primary Key,ImageLogoIconUrl varchar(100),
ImageSmall varchar(100),ImageUrl varchar(100));

------------------------------
--SEORepository
------------------------------
Create table SEORepository(SEOid bigint Identity(1,1) Primary Key,SEOPageTitle varchar(50),SEODescriptionTag varchar(500),
SEOMetaTag varchar(200),SEOKeywords varchar(100));

------------------------------
--CategoryMaster
------------------------------
Create table CategoryMaster(CategoryId bigint Identity(1,1) Primary Key,CategoryName varchar(30) not null,
CategoryDescription varchar(100) not null,
CategorySEOId bigint FOREIGN KEY REFERENCES SEORepository(SEOid),
CategoryImageId bigint FOREIGN KEY REFERENCES ImageRepository(ImageId),
CategoryIsParent bit default 0 not null,CategoryParentId bigint,
CategoryIsMenu bit default 0 not null,CategoryIsActive bit default 0 not null,
CategoryCreatedDate datetime,CategoryChangedDate datetime,CategoryChangedBy bigint);

------------------------------
--SubCategoryMaster
------------------------------
Create table SubCategoryMaster(SubCategoryId bigint Identity(1,1) Primary Key,SubCategoryName varchar(30) not null,
SubCategoryDescription varchar(100) not null,
SubCategorySEOId bigint FOREIGN KEY REFERENCES SEORepository(SEOid),
SubCategoryImageId bigint FOREIGN KEY REFERENCES ImageRepository(ImageId),
SubCategoryIsParent bit default 0 not null,SubCategoryParentId bigint,
SubCategoryIsMenu bit default 0 not null,SubCategoryIsActive bit default 0 not null,
SubCategoryCreatedDate datetime,SubCategoryChangedDate datetime,SubCategoryChangedBy bigint);

------------------------------
--TypeCategoryMaster
------------------------------
Create table TypeCategoryMaster(TypeCategoryId bigint Identity(1,1) Primary Key,TypeCategoryName varchar(30) not null,
TypeCategoryDescription varchar(100) not null,
TypeCategorySEOId bigint FOREIGN KEY REFERENCES SEORepository(SEOid),
TypeCategoryImageId bigint FOREIGN KEY REFERENCES ImageRepository(ImageId),
TypeCategoryIsParent bit default 0 not null,TypeCategoryParentId bigint,
TypeCategoryIsMenu bit default 0 not null,TypeCategoryIsActive bit default 0 not null,
TypeCategoryCreatedDate datetime,TypeCategoryChangedDate datetime,TypeCategoryChangedBy bigint);

------------------------------
--CategoryMappings
------------------------------
Create table CategoryMappings(CategoryMappingId bigint Identity(1,1) Primary Key,
CategoryId bigint FOREIGN KEY REFERENCES CategoryMaster(CategoryId),
SubCategoryId bigint FOREIGN KEY REFERENCES SubCategoryMaster(SubCategoryId),
TypeCategoryId bigint FOREIGN KEY REFERENCES TypeCategoryMaster(TypeCategoryId),
CategoryMappingIsActive bit default 0 not null,
CategoryMappingCreatedDate datetime,CategoryMappingChangedDate datetime,CategoryMappingChangedBy bigint);

------------------------------
--ProductMaster
------------------------------
Create table ProductMaster(ProductId bigint Identity(1,1) Primary Key,ProductName varchar(30) not null,
ProductDescription varchar(100) not null,
ProductSEOId bigint FOREIGN KEY REFERENCES SEORepository(SEOid),
ProductImageId bigint FOREIGN KEY REFERENCES ImageRepository(ImageId),
ProductIsMenu bit default 0 not null,ProductIsActive bit default 0 not null,
ProductCreatedDate datetime,ProductChangedDate datetime,ProductChangedBy bigint);

------------------------------
--CompanyMaster
------------------------------
Create table CompanyMaster(CompanyId bigint Identity(1,1) Primary Key,CompanyName varchar(30) not null,
CompanyDescription varchar(100) not null,
CompanySEOId bigint FOREIGN KEY REFERENCES SEORepository(SEOid),
CompanyImageId bigint FOREIGN KEY REFERENCES ImageRepository(ImageId),
CompanyIsMenu bit default 0 not null,CompanyIsActive bit default 0 not null,
CompanyCreatedDate datetime,CompanyChangedDate datetime,CompanyChangedBy bigint);

------------------------------
--BrandMaster
------------------------------
Create table BrandMaster(
BrandCompanyId bigint FOREIGN KEY REFERENCES CompanyMaster(CompanyId),
BrandId bigint Identity(1,1) Primary Key,BrandName varchar(30) not null,
BrandDescription varchar(100) not null,
BrandSEOId bigint FOREIGN KEY REFERENCES SEORepository(SEOid),
BrandImageId bigint FOREIGN KEY REFERENCES ImageRepository(ImageId),
BrandIsMenu bit default 0 not null,BrandIsActive bit default 0 not null,
BrandCreatedDate datetime,BrandChangedDate datetime,BrandChangedBy bigint);

------------------------------
--SpecificationMaster
------------------------------
Create table SpecificationMaster(SpecificationID bigint Identity(1,1) Primary Key,
SpecificationDescription varchar(50),SpecificationIsActive bit default 0,
SpecificationCreatedOn DateTime,SpecificationChangedOn datetime,SpecificationChangedBy bigint);

------------------------------
--SpecificationValuesMaster
------------------------------
Create table SpecificationValuesMaster(SpecificationValueID bigint Identity(1,1) Primary Key,
SpecificationValue varchar(50),SpecificationValueIsActive bit default 0,
SpecificationValueCreatedOn DateTime,SpecificationValueChangedOn datetime,SpecificationValueChangedBy bigint);

------------------------------
--ProductSpecification
------------------------------
Create table ProductSpecification(ProductSpecificationId bigint Identity(1,1) Primary Key,
ProductId bigint foreign key references  ProductMaster(ProductId),
SpecificationId bigint foreign key references  SpecificationMaster(SpecificationID),
SpecificationValueId bigint foreign key references  SpecificationValuesMaster(SpecificationValueID),
ProductSpecificationIsActive bit default 0,
ProductSpecificationCreatedOn DateTime,ProductSpecificationChangedOn datetime,ProductSpecificationChangedBy bigint);

------------------------------
--SKUMaster
------------------------------

Create table SKUMaster(SKUID bigint Identity(1,1) Primary Key,
SKUCompanyID bigint foreign key references  CompanyMaster(CompanyId),
SKUBrandID bigint foreign key references  BrandMaster(BrandId),
SKUProductId bigint foreign key references  ProductMaster(ProductId),
SKUCategoryMappingID bigint foreign key references  CategoryMappings(CategoryMappingId),
SKUIsActive bit default 0,
SKUCreatedOn DateTime,SKUChangedOn datetime,SKUChangedBy bigint);

------------------------------
--SKUInventory
------------------------------
Create table SKUInventory(SKUInventoryId bigint Identity(1,1) Primary Key,
SKUID bigint foreign key references  SKUMaster(SKUID),
SKUQTY bigint,
SKUMInOrderQTY bigint,
SKUMinLevelIndicator bigint,
SKUInventoryCreatedOn DateTime,SKUInventoryChangedOn datetime,SKUInventoryChangedBy bigint);

------------------------------
--SKUDiscount
------------------------------
Create table SKUDiscount(DiscountId bigint Identity(1,1) Primary Key,
SKUID bigint foreign key references  SKUMaster(SKUID),
SKUDiscountPercent decimal,
SKUDiscountIsActive bit default 0,
SKUDiscountCreatedOn DateTime,SKUDiscountChangedOn datetime,SKUDiscountChangedBy bigint);

------------------------------
--VendorMaster
------------------------------

Create table VendorMaster(VendorId bigint Identity(1,1) Primary Key,
VendorName varchar(50),VendorAddress1 varchar(100),VendorAddress2 varchar(100),
VendorAddress3 varchar(100),VendorZipCode varchar(15),VendorOwnerName varchar(50),
VendorOwnerPhoneNo varchar(15),VendorShopPhoneNo varchar(15),VendorTINNO varchar(30),
VendorPANNO varchar(30),VendorTANNO varchar(30),VendorSalesTaxNo varchar(30),
VendorLicenceNo varchar(30),VendorIsActive bit,
VendorCreatedOn DateTime,VendorChangedOn datetime,VendorChangedBy bigint);

------------------------------
--SKUVendor
------------------------------

Create table SKUVendor(SKUVendorId bigint Identity(1,1) Primary Key,
VendorID bigint foreign key references VendorMaster(VendorId),
SKUID bigint foreign key references SKUMaster(SKUID ),
SKUVendorQty int,
SKUVendorIsActive bit,
SKUVendorCreatedOn DateTime,SKUVendorChangedOn datetime,SKUVendorChangedBy bigint);




-- Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB;Database=LiquorsCart;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir DataModels