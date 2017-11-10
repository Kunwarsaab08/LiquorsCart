﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DomainModel.Inventory
{
    public class Category : MasterDM
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public SeoRepository CategorySEOId { get; set; }

        public ImageRepository  CategoryImageId { get; set; }

        public bool CategoryIsParent { get; set; }

        public int CategoryParentId { get; set; }

        public bool CategoryIsMenu { get; set; }

        public bool CategoryIsActive { get; set; }

        public DateTime? CategoryCreatedDate { get; set; }

        public DateTime? CategoryChangeDate { get; set; }

        public int CategoryChangeBy { get; set; }
    }
}