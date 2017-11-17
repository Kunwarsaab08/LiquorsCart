using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class ImageRepository : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 ImageId { get; set; }

        [StringLength(100)]
        public string ImageLogoIcon { get; set; }

        [StringLength(100)]
        public string ImageSmallUrl { get; set; }

        [StringLength(100)]
        public string ImageLargeUrl { get; set; }
    }
}
