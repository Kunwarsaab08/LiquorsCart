using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataModel.DataModels.Inventory
{
    public class ImageRepository : MasterDM
    {
        [Key]
        public int ImageId { get; set; }

        public string ImageLogoIcon { get; set; }

        public string ImageSmallUrl { get; set; }

        public string ImageLargeUrl { get; set; }
    }
}
