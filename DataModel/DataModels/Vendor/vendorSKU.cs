using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Vendor
{
    public class VendorSKU : MasterDM
    {
        [Key]
        public int VendorSKUID { get; set; }

        public int VendorId { get; set; }

        public int VendorSKUProductID { get; set; }

        public int VendorSKUProductQty { get; set; }

        public bool VendorSKUIsActive { get; set; }

        public DateTime? VendorSKUCreatedDate { get; set; }

        public DateTime? VendorSKUChangeDate { get; set; }

        public int VendorSKKUChangeBy { get; set; }
    }
}
