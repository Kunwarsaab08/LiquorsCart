using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class SeoRepository : MasterDM
    {
        [Key]
        public int SeoId { get; set; }

        public string SeoPageTitle { get; set; }

        public string SeoDescriptionTag { get; set; }

        public string SeoMetaTag { get; set; }

        public string SeoKeywords { get; set; }
    }
}
