using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataModel.DataModels.Inventory
{
    public class TypeCategory : MasterDM
    {
        [Key]
        public int TypeCategoryId { get; set; }

        public string TypeCategoryName { get; set; }

        public string TypeCategoryDescription { get; set; }

        public SeoRepository TypeCategorySEOId { get; set; }

        public ImageRepository TypeCategoryImageId { get; set; }

        public bool TypeCategoryIsParent { get; set; }

        public int TypeCategoryParentId { get; set; }

        public bool TypeCategoryIsMenu { get; set; }

        public bool TypeCategoryIsActive { get; set; }

        public DateTime? TypeCategoryCreatedDate { get; set; }

        public DateTime? TypeCategoryChangeDate { get; set; }

        public int TypeCategoryChangeBy { get; set; }
    }
}
