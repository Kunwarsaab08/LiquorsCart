using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class CategoryMappings : MasterDM
    {
        [Key]
        public int CategoryMappingId { get; set; }

        public int MainCategoryId { get; set; }

        public int SubCategoryId { get; set; }

        public int TypeCategoryId { get; set; }

        public bool CategoryMappingIsActive { get; set; }

        public DateTime? CategoryMappingCreatedDate { get; set; }

        public DateTime? CategoryMappingChangeDate { get; set; }

        public int CategoryChangeBy { get; set; }
    }
}
