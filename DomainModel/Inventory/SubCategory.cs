using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DomainModel.Inventory
{
    public class SubCategory : MasterDM
    {
        [Key]
        public int SubCategoryId { get; set; }

        public string SubCategoryName { get; set; }

        public string SubCategoryDescription { get; set; }

        public SeoRepository SubCategorySEOId { get; set; }

        public ImageRepository SubCategoryImageId { get; set; }

        public bool SubCategoryIsParent { get; set; }

        public int SubCategoryParentId { get; set; }

        public bool SubCategoryIsMenu { get; set; }

        public bool SubCategoryIsActive { get; set; }

        public DateTime? SubCategoryCreatedDate { get; set; }

        public DateTime? SubCategoryChangeDate { get; set; }

        public int SubCategoryChangeBy { get; set; }
    }
}
