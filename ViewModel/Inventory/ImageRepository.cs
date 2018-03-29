using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.ViewModel.Inventory
{
    public class ImageRepository : MasterDM
    {
        public Int64 ImageId { get; set; }

        public string ImageLogoIcon { get; set; }

        public string ImageSmallUrl { get; set; }

        public string ImageLargeUrl { get; set; }
    }
}
