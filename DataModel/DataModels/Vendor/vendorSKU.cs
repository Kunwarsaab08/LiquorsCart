using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Vendor
{
    public class VendorSKU : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 VendorSKUID { get; set; }

        [Required]
        [ForeignKey(name: "Vendor")]
        public Int64 VendorId { get; set; }

        [Required]
        public Int64 VendorSKUProductID { get; set; }

        [Required]
        public int VendorSKUProductQty { get; set; }

        [Required]
        public bool VendorSKUIsActive { get; set; }

        public DateTime? VendorSKUCreatedDate { get; set; }

        public DateTime? VendorSKUChangeDate { get; set; }

        public int VendorSKKUChangeBy { get; set; }
    }
}
