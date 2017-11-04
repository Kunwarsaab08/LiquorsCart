using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataModel.DataModels.Inventory
{
    public class CategoryMappings : MasterDM
    {
        [Key]
        public int CategoryMappingId { get; set; }

        public Category MainCategoryId { get; set; }

        public SubCategory SubCategoryId { get; set; }

        public TypeCategory TypeCategoryId { get; set; }

        public bool CategoryMappingIsActive { get; set; }

        public DateTime? CategoryMappingCreatedDate { get; set; }

        public DateTime? CategoryMappingChangeDate { get; set; }

        public int CategoryChangeBy { get; set; }
    }
}
