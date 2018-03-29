using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class ProductSKU : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 ProductSKUID { get; set; }

        [Required]
        [ForeignKey(name: "Company")]
        public Int64 ProductSKUCompanyId { get; set; }

        [Required]
        [ForeignKey(name: "Brand")]
        public Int64 ProductSKUBrandId { get; set; }

        [Required]
        [ForeignKey(name: "Product")]
        public Int64 ProductSKUProductId { get; set; }

        [Required]
        [ForeignKey(name: "CategoryMappings")]
        public Int64 ProductSKUCategoryMappingId { get; set; }

        [Required]
        public bool ProductSKUISActive { get; set; }

        public DateTime? ProductSKUCreatedDate { get; set; }

        public DateTime? ProductSKUChangeDate { get; set; }

        public Int64? ProductSKUChangeBY { get; set; }
    }
}
