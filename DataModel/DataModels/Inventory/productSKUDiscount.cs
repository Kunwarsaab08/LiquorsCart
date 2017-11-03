using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModels.Inventory
{
    public class productSKUDiscount
    {
        public int productSKUDiscountId { get; set; }

        public int productSKUID { get; set; }

        public decimal productSKUDiscountPercent { get; set; }

        public bool productSKUDiscountIsActive { get; set; }

        public DateTime productSKUDiscountCreatedDate { get; set; }

        public DateTime? productSKUDiscountChangeDate { get; set; }

        public int productSKUDiscountChangeBy { get; set; }
    }
}
