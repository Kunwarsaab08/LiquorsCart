using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DomainModel.Inventory
{
    public class ProductSKUDiscount : MasterDM
    {
        [Key]
        public int ProductSKUDiscountId { get; set; }

        public ProductSKU ProductSKUID { get; set; }

        public decimal ProductSKUDiscountPercent { get; set; }

        public bool ProductSKUDiscountIsActive { get; set; }

        public DateTime? ProductSKUDiscountCreatedDate { get; set; }

        public DateTime? ProductSKUDiscountChangeDate { get; set; }

        public int ProductSKUDiscountChangeBy { get; set; }
    }
}
