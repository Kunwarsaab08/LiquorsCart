using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModels.Inventory
{
    public class product
    {
        public int productId { get; set; }

        public string productName { get; set; }

        public string productDescription { get; set; }

        public int productSEOId { get; set; }

        public int productImageId { get; set; }

        public bool productIsActive { get; set; }

        public bool productIsMenu { get; set; }

        public DateTime productCreatedDate { get; set; }

        public DateTime? productChangedDate { get; set; }

        public int productChangedBy { get; set; }
    }
}
