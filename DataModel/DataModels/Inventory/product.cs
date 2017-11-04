using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataModel.DataModels.Inventory
{
    public class Product : MasterDM
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public SeoRepository ProductSEOId { get; set; }

        public ImageRepository ProductImageId { get; set; }

        public bool ProductIsActive { get; set; }

        public bool ProductIsMenu { get; set; }

        public DateTime? ProductCreatedDate { get; set; }

        public DateTime? ProductChangedDate { get; set; }

        public int ProductChangedBy { get; set; }
    }
}
