using DA = LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using DM = LiquorsCart.ServerSide.DomainModel.Inventory;

namespace LiquorsCart.ServerSide.Transformation
{
    public class Inventory_DomainModel_X_DataModel
    {
        public DA.Brand Change(DM.Brand dmBrand) => new DA.Brand()
        {
            CompanyId = dmBrand.CompanyId.CompanyId,
            BrandId = dmBrand.BrandId,
            BrandName = dmBrand.BrandName,
            BrandDescription = dmBrand.BrandDescription,
            BrandSEOId = dmBrand.BrandSEOId.SeoId,
            BrandImageId = dmBrand.BrandImageId.ImageId,
            BrandIsMenu = dmBrand.BrandIsMenu,
            BrandIsActive = dmBrand.BrandIsActive,
            BrandCreatedDate = dmBrand.BrandCreatedDate,
            BrandChangeDate = dmBrand.BrandChangeDate,
            BrandChangeby = dmBrand.BrandChangeby
        };

        public DA.Category Change(DM.Category dmCategory) => new DA.Category()
        {
            CategoryId = dmCategory.CategoryId,
            CategoryName = dmCategory.CategoryName,
            CategoryDescription = dmCategory.CategoryDescription,
            CategorySEOId = dmCategory.CategorySEOId.SeoId,
            CategoryImageId = dmCategory.CategoryImageId.ImageId,
            CategoryIsParent = dmCategory.CategoryIsParent,
            CategoryParentId = dmCategory.CategoryParentId,
            CategoryIsMenu = dmCategory.CategoryIsMenu,
            CategoryIsActive = dmCategory.CategoryIsActive,
            CategoryCreatedDate = dmCategory.CategoryCreatedDate,
            CategoryChangeDate = dmCategory.CategoryChangeDate,
            CategoryChangeBy = dmCategory.CategoryChangeBy
        };

        public DA.CategoryMappings Change(DM.CategoryMappings dmCategoryMappings) => new DA.CategoryMappings()
        {
            CategoryMappingId = dmCategoryMappings.CategoryMappingId,
            MainCategoryId = dmCategoryMappings.MainCategoryId.CategoryId,
            SubCategoryId = dmCategoryMappings.SubCategoryId.SubCategoryId,
            TypeCategoryId = dmCategoryMappings.TypeCategoryId.TypeCategoryId,
            CategoryMappingIsActive = dmCategoryMappings.CategoryMappingIsActive,
            CategoryMappingCreatedDate = dmCategoryMappings.CategoryMappingCreatedDate,
            CategoryMappingChangeDate = dmCategoryMappings.CategoryMappingChangeDate,
            CategoryChangeBy = dmCategoryMappings.CategoryChangeBy
        };

        public DA.Company Change(DM.Company dmCompany) => new DA.Company()
        {
            CompanyId = dmCompany.CompanyId,
            CompanyName = dmCompany.CompanyName,
            CompanyDescription = dmCompany.CompanyDescription,
            CompanySEOId = dmCompany.CompanySEOId.SeoId,
            CompanyImageId = dmCompany.CompanyImageId.ImageId,
            CompanyIsMenu = dmCompany.CompanyIsMenu,
            CompanyIsActive = dmCompany.CompanyIsActive,
            CompanyCreatedDate = dmCompany.CompanyCreatedDate,
            CompanyChangeDate = dmCompany.CompanyChangeDate,
            CompanyChangeBy = dmCompany.CompanyChangeBy
        };

        public DA.ImageRepository Change(DM.ImageRepository dmImageRepository) => new DA.ImageRepository()
        {
            ImageId = dmImageRepository.ImageId,
            ImageLogoIcon = dmImageRepository.ImageLogoIcon,
            ImageSmallUrl = dmImageRepository.ImageSmallUrl,
            ImageLargeUrl = dmImageRepository.ImageLargeUrl
        };

        public DA.Product Change(DM.Product dmProduct) => new DA.Product()
        {
            ProductId = dmProduct.ProductId,
            ProductName = dmProduct.ProductName,
            ProductDescription = dmProduct.ProductDescription,
            ProductSEOId = dmProduct.ProductSEOId.SeoId,
            ProductImageId = dmProduct.ProductImageId.ImageId,
            ProductIsActive = dmProduct.ProductIsActive,
            ProductIsMenu = dmProduct.ProductIsMenu,
            ProductCreatedDate = dmProduct.ProductCreatedDate,
            ProductChangedDate = dmProduct.ProductChangedDate,
            ProductChangedBy = dmProduct.ProductChangedBy
        };

        public DA.ProductSKU Change(DM.ProductSKU dmProductSKU) => new DA.ProductSKU()
        {
            ProductSKUID = dmProductSKU.ProductSKUID,
            ProductSKUCompanyId = dmProductSKU.ProductSKUCompanyId.CompanyId,
            ProductSKUBrandId = dmProductSKU.ProductSKUBrandId.BrandId,
            ProductSKUProductId = dmProductSKU.ProductSKUProductId.ProductId,
            ProductSKUCategoryMappingId = dmProductSKU.ProductSKUCategoryMappingId.CategoryMappingId,
            ProductSKUISActive = dmProductSKU.ProductSKUISActive,
            ProductSKUCreatedDate = dmProductSKU.ProductSKUCreatedDate,
            ProductSKUChangeDate = dmProductSKU.ProductSKUChangeDate,
            ProductSKUChangeBY = dmProductSKU.ProductSKUChangeBY
        };

        public DA.ProductSKUDiscount Change(DM.ProductSKUDiscount dmProductSKUDiscount) => new DA.ProductSKUDiscount()
        {
            ProductSKUDiscountId = dmProductSKUDiscount.ProductSKUDiscountId,
            ProductSKUID = dmProductSKUDiscount.ProductSKUID.ProductSKUID,
            ProductSKUDiscountPercent = dmProductSKUDiscount.ProductSKUDiscountPercent,
            ProductSKUDiscountIsActive = dmProductSKUDiscount.ProductSKUDiscountIsActive,
            ProductSKUDiscountCreatedDate = dmProductSKUDiscount.ProductSKUDiscountCreatedDate,
            ProductSKUDiscountChangeDate = dmProductSKUDiscount.ProductSKUDiscountChangeDate,
            ProductSKUDiscountChangeBy = dmProductSKUDiscount.ProductSKUDiscountChangeBy
        };

        public DA.ProductSKUInventory Change(DM.ProductSKUInventory dmProductSKUInventory) => new DA.ProductSKUInventory()
        {
            ProductSKUInventoryId = dmProductSKUInventory.ProductSKUInventoryId,
            ProductSKUId = dmProductSKUInventory.ProductSKUId.ProductSKUID,
            ProductSKUQty = dmProductSKUInventory.ProductSKUQty,
            ProductSKUMinOrderQty = dmProductSKUInventory.ProductSKUMinOrderQty,
            ProductSKUMinLevelIndicator = dmProductSKUInventory.ProductSKUMinLevelIndicator,
            ProductSKUInventoryCreatedDate = dmProductSKUInventory.ProductSKUInventoryCreatedDate,
            ProductSKUInventoryChangeDate = dmProductSKUInventory.ProductSKUInventoryChangeDate,
            ProductSKUInventoryChangeBy = dmProductSKUInventory.ProductSKUInventoryChangeBy
        };


        public DA.ProductSpecification Change(DM.ProductSpecification dmProductSpecification) => new DA.ProductSpecification()
        {
            ProductSpecificationID = dmProductSpecification.ProductSpecificationID,
            ProductID = dmProductSpecification.ProductID.ProductId,
            ProductSpecificationsID = dmProductSpecification.ProductSpecificationsID.SpecificationID,
            ProductSpecificationValuesID = dmProductSpecification.ProductSpecificationValuesID.SpecificationValueId,
            ProductSpecificationISActive = dmProductSpecification.ProductSpecificationISActive,
            ProductSpecificationCreatedDate = dmProductSpecification.ProductSpecificationCreatedDate,
            ProductSpecificationChangeDate = dmProductSpecification.ProductSpecificationChangeDate,
            ProductSpecificationChangeBy = dmProductSpecification.ProductSpecificationChangeBy
        };

        public DA.SeoRepository Change(DM.SeoRepository dmSeoRepository) => new DA.SeoRepository()
        {
            SeoId = dmSeoRepository.SeoId,
            SeoPageTitle = dmSeoRepository.SeoPageTitle,
            SeoDescriptionTag = dmSeoRepository.SeoDescriptionTag,
            SeoMetaTag = dmSeoRepository.SeoMetaTag,
            SeoKeywords = dmSeoRepository.SeoKeywords
        };

        public DA.Specification Change(DM.Specification dmSpecification) => new DA.Specification()
        {
            SpecificationID = dmSpecification.SpecificationID,
            SpecificationDescription = dmSpecification.SpecificationDescription,
            SpecificationIsActive = dmSpecification.SpecificationIsActive,
            SpecificationCreatedDate = dmSpecification.SpecificationCreatedDate,
            SpecificationChangedDate = dmSpecification.SpecificationChangedDate,
            SpecificationChangeBy = dmSpecification.SpecificationChangeBy
        };

        public DA.SpecificationValue Change(DM.SpecificationValue dmSpecificationValue) => new DA.SpecificationValue()
        {
            SpecificationValueId = dmSpecificationValue.SpecificationValueId,
            SpecificationDesc = dmSpecificationValue.SpecificationDesc,
            SpecificationValuesIsActive = dmSpecificationValue.SpecificationValuesIsActive,
            SpecificationValueCreatedDate = dmSpecificationValue.SpecificationValueCreatedDate,
            SpecificationValueChangeDate = dmSpecificationValue.SpecificationValueChangeDate,
            SpecificationValueChangeBy = dmSpecificationValue.SpecificationValueChangeBy
        };

        public DA.SubCategory Change(DM.SubCategory dmSubCategory) => new DA.SubCategory()
        {
            SubCategoryId = dmSubCategory.SubCategoryId,
            SubCategoryName = dmSubCategory.SubCategoryName,
            SubCategoryDescription = dmSubCategory.SubCategoryDescription,
            SubCategorySEOId = dmSubCategory.SubCategorySEOId.SeoId,
            SubCategoryImageId = dmSubCategory.SubCategoryImageId.ImageId,
            SubCategoryIsParent = dmSubCategory.SubCategoryIsParent,
            SubCategoryParentId = dmSubCategory.SubCategoryParentId,
            SubCategoryIsMenu = dmSubCategory.SubCategoryIsMenu,
            SubCategoryIsActive = dmSubCategory.SubCategoryIsActive,
            SubCategoryCreatedDate = dmSubCategory.SubCategoryCreatedDate,
            SubCategoryChangeDate = dmSubCategory.SubCategoryChangeDate,
            SubCategoryChangeBy = dmSubCategory.SubCategoryChangeBy
        };

        public DA.TypeCategory Change(DM.TypeCategory dmTypeCategory) => new DA.TypeCategory()
        {
            TypeCategoryId = dmTypeCategory.TypeCategoryId,
            TypeCategoryName = dmTypeCategory.TypeCategoryName,
            TypeCategoryDescription = dmTypeCategory.TypeCategoryDescription,
            TypeCategorySEOId = dmTypeCategory.TypeCategorySEOId.SeoId,
            TypeCategoryImageId = dmTypeCategory.TypeCategoryImageId.ImageId,
            TypeCategoryIsParent = dmTypeCategory.TypeCategoryIsParent,
            TypeCategoryParentId = dmTypeCategory.TypeCategoryParentId,
            TypeCategoryIsMenu = dmTypeCategory.TypeCategoryIsMenu,
            TypeCategoryIsActive = dmTypeCategory.TypeCategoryIsActive,
            TypeCategoryCreatedDate = dmTypeCategory.TypeCategoryCreatedDate,
            TypeCategoryChangeDate = dmTypeCategory.TypeCategoryChangeDate,
            TypeCategoryChangeBy = dmTypeCategory.TypeCategoryChangeBy
        };
    }
}
