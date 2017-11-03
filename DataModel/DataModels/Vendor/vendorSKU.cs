using System;
using System.Collections.Generic;
using System.Text;
using DataModel.DataModels.Inventory;

namespace DataModel.DataModels.Vendor
{
    public class vendorSKU
    {
        public int vendorSKUID { get; set; }

        public int vendorId { get; set; }

        public int vendorSKUProductID { get; set; }

        public int vendorSKUProductQty { get; set; }

        public bool vendorSKUIsActive { get; set; }

        public DateTime vendorSKUCreatedDate { get; set; }

        public DateTime? vendorSKUChangeDate { get; set; }

        public int vendorSKKUChangeBy { get; set; }
    }
}
