using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Vendor
{
    public class Vendor : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 VendorID { get; set; }

        [Required]
        [StringLength(50)]
        public string VendorName { get; set; }

        [StringLength(100)]
        public string VendorAddress1 { get; set; }

        [StringLength(100)]
        public string VemdorAddress2 { get; set; }

        [StringLength(100)]
        public string VendorAddress3 { get; set; }

        [StringLength(15)]
        public string VendorZIPcode { get; set; }

        [StringLength(50)]
        public string VendorOwnerName { get; set; }

        [StringLength(15)]
        public string VendorOwnerPhoneNo { get; set; }

        [StringLength(15)]
        public string VendorShopPhoneNo { get; set; }

        [StringLength(30)]
        public string VendorTINno { get; set; }

        [StringLength(30)]
        public string VendorPANno { get; set; }

        [StringLength(30)]
        public string VendorTANno { get; set; }

        [StringLength(30)]
        public string VendorSALESTAXno { get; set; }

        [StringLength(30)]
        public string VendorLicenceno { get; set; }

        [Required]
        public bool VendorIsActive { get; set; }

        public DateTime? VendorCreatedDate { get; set; }

        public DateTime? VendorChangeDate { get; set; }

        public int VendorChangeBy { get; set; }
    }
}
