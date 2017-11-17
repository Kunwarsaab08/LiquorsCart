using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class SeoRepository : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 SeoId { get; set; }

        [StringLength(50)]
        public string SeoPageTitle { get; set; }

        [StringLength(500)]
        public string SeoDescriptionTag { get; set; }

        [StringLength(200)]
        public string SeoMetaTag { get; set; }

        [StringLength(100)]
        public string SeoKeywords { get; set; }
    }
}
