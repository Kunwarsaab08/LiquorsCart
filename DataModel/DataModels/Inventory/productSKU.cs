using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class ProductSKU : MasterDM
    {
        [Key]
        public int ProductSKUID { get; set; }

        public int ProductSKUCompanyId { get; set; }

        public int ProductSKUBrandId { get; set; }

        public int ProductSKUProductId { get; set; }

        public int  ProductSKUCategoryMappingId { get; set; }

        public bool ProductSKUISActive { get; set; }

        public DateTime? ProductSKUCreatedDate { get; set; }

        public DateTime? ProductSKUChangeDate { get; set; }

        public int ProductSKUChangeBY { get; set; }
    }
}
