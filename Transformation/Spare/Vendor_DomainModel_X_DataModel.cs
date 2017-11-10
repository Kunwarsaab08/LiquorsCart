using DA = LiquorsCart.ServerSide.DataModel.DataModels.Vendor;
using DM = LiquorsCart.ServerSide.DomainModel.Vendor;

namespace LiquorsCart.ServerSide.Transformation
{
    public class Vendor_DomainModel_X_DataModel
    {
        public DA.Vendor Change(DM.Vendor dmVendor) => new DA.Vendor()
        {
            VendorID = dmVendor.VendorID,
            VendorName = dmVendor.VendorName,
            VendorAddress1 = dmVendor.VendorAddress1,
            VemdorAddress2 = dmVendor.VemdorAddress2,
            VendorAddress3 = dmVendor.VendorAddress3,
            VendorZIPcode = dmVendor.VendorZIPcode,
            VendorOwnerName = dmVendor.VendorOwnerName,
            VendorOwnerPhoneNo = dmVendor.VendorOwnerPhoneNo,
            VendorShopPhoneNo = dmVendor.VendorShopPhoneNo,
            VendorTINno = dmVendor.VendorTINno,
            VendorPANno = dmVendor.VendorPANno,
            VendorTANno = dmVendor.VendorTANno,
            VendorSALESTAXno = dmVendor.VendorSALESTAXno,
            VendorLicenceno = dmVendor.VendorLicenceno,
            VendorIsActive = dmVendor.VendorIsActive,
            VendorCreatedDate = dmVendor.VendorCreatedDate,
            VendorChangeDate = dmVendor.VendorChangeDate,
            VendorChangeBy = dmVendor.VendorChangeBy
        };

        public DA.VendorSKU Change(DM.VendorSKU dmVendorSKU) => new DA.VendorSKU()
        {
            VendorSKUID = dmVendorSKU.VendorSKUID,
            VendorId = dmVendorSKU.VendorId.VendorID,
            VendorSKUProductID = dmVendorSKU.VendorSKUProductID.ProductSKUID,
            VendorSKUProductQty = dmVendorSKU.VendorSKUProductQty,
            VendorSKUIsActive = dmVendorSKU.VendorSKUIsActive,
            VendorSKUCreatedDate = dmVendorSKU.VendorSKUCreatedDate,
            VendorSKUChangeDate = dmVendorSKU.VendorSKUChangeDate,
            VendorSKKUChangeBy = dmVendorSKU.VendorSKKUChangeBy
        };
    }
}
