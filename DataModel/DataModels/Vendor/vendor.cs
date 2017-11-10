using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Vendor
{
    public class Vendor : MasterDM
    {
        [Key]
        public int VendorID { get; set; }

        public string VendorName { get; set; }

        public string VendorAddress1 { get; set; }

        public string VemdorAddress2 { get; set; }

        public string VendorAddress3 { get; set; }

        public string VendorZIPcode { get; set; }

        public string VendorOwnerName { get; set; }

        public string VendorOwnerPhoneNo { get; set; }

        public string VendorShopPhoneNo { get; set; }

        public string VendorTINno { get; set; }

        public string VendorPANno { get; set; }

        public string VendorTANno { get; set; }

        public string VendorSALESTAXno { get; set; }

        public string VendorLicenceno { get; set; }

        public bool VendorIsActive { get; set; }

        public DateTime? VendorCreatedDate { get; set; }

        public DateTime? VendorChangeDate { get; set; }

        public int VendorChangeBy { get; set; }
    }
}
