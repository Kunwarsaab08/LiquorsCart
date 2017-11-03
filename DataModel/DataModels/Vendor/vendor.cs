using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModels.Vendor
{
    public class vendor
    {
        public int vendorID { get; set; }

        public string vendorName { get; set; }

        public string vendorAddress1 { get; set; }

        public string vemdorAddress2 { get; set; }

        public string vendorAddress3 { get; set; }

        public string vendorZIPcode { get; set; }

        public string vendorOwnerName { get; set; }

        public string vendorOwnerPhoneNo { get; set; }

        public string vendorShopPhoneNo { get; set; }

        public string vendorTINno { get; set; }

        public string vendorPANno { get; set; }

        public string vendorTANno { get; set; }

        public string vendorSALESTAXno { get; set; }

        public string vendorLicenceno { get; set; }

        public bool vendorIsActive { get; set; }

        public DateTime vendorCreatedDate { get; set; }

        public DateTime? vendorChangeDate { get; set; }

        public int vendorChangeBy { get; set; }
    }
}
