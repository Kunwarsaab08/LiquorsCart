using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModels.Inventory
{
    public class productSKU
    {
        public int productSKUID { get; set; }

        public int productSKUCompanyId { get; set; }

        public int productSKUBrandId { get; set; }

        public int productSKUProductId { get; set; }

        public int  productSKUCategoryMappingId { get; set; }

        public bool productSKUISActive { get; set; }

        public DateTime productSKUCreatedDate { get; set; }

        public DateTime? productSKUChangeDate { get; set; }

        public int productSKUChangeBY { get; set; }
    }
}
