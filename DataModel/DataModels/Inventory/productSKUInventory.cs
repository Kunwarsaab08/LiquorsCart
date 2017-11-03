using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModels.Inventory
{
    public class productSKUInventory
    {
        public int productSKUInventoryId { get; set; }

        public int productSKUId { get; set; }

        public int productSKUQty { get; set; }

        public int productSKUMinOrderQty { get; set; }

        public int productSKUMinLevelIndicator { get; set; }

        public DateTime productSKUInventoryCreatedDate { get; set; }

        public DateTime? productSKUInventoryChangeDate { get; set; }

        public int productSKUInventoryChangeBy { get; set; }
    }
}
