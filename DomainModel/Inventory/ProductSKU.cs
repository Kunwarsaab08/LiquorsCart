using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DomainModel.Inventory
{
    public class ProductSKU : MasterDM
    {
        [Key]
        public int ProductSKUID { get; set; }

        public Company ProductSKUCompanyId { get; set; }

        public Brand ProductSKUBrandId { get; set; }

        public Product ProductSKUProductId { get; set; }

        public CategoryMappings  ProductSKUCategoryMappingId { get; set; }

        public bool ProductSKUISActive { get; set; }

        public DateTime? ProductSKUCreatedDate { get; set; }

        public DateTime? ProductSKUChangeDate { get; set; }

        public int ProductSKUChangeBY { get; set; }
    }
}
