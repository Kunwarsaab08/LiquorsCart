using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DomainModel.Inventory
{
    public class ProductSKUInventory : MasterDM
    {
        [Key]
        public int ProductSKUInventoryId { get; set; }

        public ProductSKU ProductSKUId { get; set; }

        public int ProductSKUQty { get; set; }

        public int ProductSKUMinOrderQty { get; set; }

        public int ProductSKUMinLevelIndicator { get; set; }

        public DateTime? ProductSKUInventoryCreatedDate { get; set; }

        public DateTime? ProductSKUInventoryChangeDate { get; set; }

        public int ProductSKUInventoryChangeBy { get; set; }
    }
}
