using DA = LiquorsCart.ServerSide.DataModel.DataModels.Vendor;
using DM = LiquorsCart.ServerSide.DomainModel.Vendor;

namespace LiquorsCart.ServerSide.Transformation
{
    public class Vendor_DataModel_X_DomainModel
    {
        public DM.Vendor Change(DA.Vendor daVendor) => new DM.Vendor()
        {
            VendorID = daVendor.VendorID,
            VendorName = daVendor.VendorName,
            VendorAddress1 = daVendor.VendorAddress1,
            VemdorAddress2 = daVendor.VemdorAddress2,
            VendorAddress3 = daVendor.VendorAddress3,
            VendorZIPcode = daVendor.VendorZIPcode,
            VendorOwnerName = daVendor.VendorOwnerName,
            VendorOwnerPhoneNo = daVendor.VendorOwnerPhoneNo,
            VendorShopPhoneNo = daVendor.VendorShopPhoneNo,
            VendorTINno = daVendor.VendorTINno,
            VendorPANno = daVendor.VendorPANno,
            VendorTANno = daVendor.VendorTANno,
            VendorSALESTAXno = daVendor.VendorSALESTAXno,
            VendorLicenceno = daVendor.VendorLicenceno,
            VendorIsActive = daVendor.VendorIsActive,
            VendorCreatedDate = daVendor.VendorCreatedDate,
            VendorChangeDate = daVendor.VendorChangeDate,
            VendorChangeBy = daVendor.VendorChangeBy
        };

        public DM.VendorSKU Change(DA.VendorSKU daVendorSKU) => new DM.VendorSKU()
        {
            VendorSKUID = daVendorSKU.VendorSKUID,
            //VendorId = daVendorSKU.VendorId.VendorID,
            //VendorSKUProductID = daVendorSKU.VendorSKUProductID.ProductSKUID,
            VendorSKUProductQty = daVendorSKU.VendorSKUProductQty,
            VendorSKUIsActive = daVendorSKU.VendorSKUIsActive,
            VendorSKUCreatedDate = daVendorSKU.VendorSKUCreatedDate,
            VendorSKUChangeDate = daVendorSKU.VendorSKUChangeDate,
            VendorSKKUChangeBy = daVendorSKU.VendorSKKUChangeBy
        };
    }
}
