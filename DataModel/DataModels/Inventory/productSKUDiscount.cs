using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class ProductSKUDiscount : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 ProductSKUDiscountId { get; set; }

        [Required]
        [ForeignKey(name: "ProductSKU")]
        public Int64 ProductSKUID { get; set; }

        [Required]
        public decimal ProductSKUDiscountPercent { get; set; }

        [Required]
        public bool ProductSKUDiscountIsActive { get; set; }

        public DateTime? ProductSKUDiscountCreatedDate { get; set; }

        public DateTime? ProductSKUDiscountChangeDate { get; set; }

        public int ProductSKUDiscountChangeBy { get; set; }
    }
}
