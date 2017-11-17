using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class ProductSKUInventory : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 ProductSKUInventoryId { get; set; }

        [Required]
        [ForeignKey(name: "ProductSKU")]
        public Int64 ProductSKUId { get; set; }

        [Required]
        public int ProductSKUQty { get; set; }

        [Required]
        public int ProductSKUMinOrderQty { get; set; }

        [Required]
        public int ProductSKUMinLevelIndicator { get; set; }

        public DateTime? ProductSKUInventoryCreatedDate { get; set; }

        public DateTime? ProductSKUInventoryChangeDate { get; set; }

        public int ProductSKUInventoryChangeBy { get; set; }
    }
}
