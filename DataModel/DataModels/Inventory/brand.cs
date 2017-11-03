using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModels.Inventory
{
    public class brand : masterDM
    {
        public company  company { get; set; }

        public int brandId { get; set; }

        public string brandName { get; set; }

        public string brandDescription { get; set; }

        public int brandSEOId { get; set; }

        public int brandImageId { get; set; }

        public bool brandIsMenu { get; set; }

        public bool brandIsActive { get; set; }

        public DateTime brandCreatedDate { get; set; }

        public DateTime? brandChangeDate { get; set; }

        public int brandChangeby { get; set; }
    }
}
