using System;
using System.Collections.Generic;
using System.Text;
using DataModel.DataModels.Inventory;
using System.ComponentModel.DataAnnotations;

namespace DataModel.DataModels.Vendor
{
    public class VendorSKU : MasterDM
    {
        [Key]
        public int VendorSKUID { get; set; }

        public Vendor VendorId { get; set; }

        public ProductSKU VendorSKUProductID { get; set; }

        public int VendorSKUProductQty { get; set; }

        public bool VendorSKUIsActive { get; set; }

        public DateTime? VendorSKUCreatedDate { get; set; }

        public DateTime? VendorSKUChangeDate { get; set; }

        public int VendorSKKUChangeBy { get; set; }
    }
}
