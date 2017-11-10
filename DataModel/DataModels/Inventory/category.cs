using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class Category : MasterDM
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public int CategorySEOId { get; set; }

        public int  CategoryImageId { get; set; }

        public bool CategoryIsParent { get; set; }

        public int CategoryParentId { get; set; }

        public bool CategoryIsMenu { get; set; }

        public bool CategoryIsActive { get; set; }

        public DateTime? CategoryCreatedDate { get; set; }

        public DateTime? CategoryChangeDate { get; set; }

        public int CategoryChangeBy { get; set; }
    }
}
