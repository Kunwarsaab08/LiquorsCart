using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class CategoryMappings : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 CategoryMappingId { get; set; }

        [Required]
        [ForeignKey(name: "Category")]
        public Int64 MainCategoryId { get; set; }

        [Required]
        [ForeignKey(name: "SubCategory")]
        public Int64 SubCategoryId { get; set; }

        [Required]
        [ForeignKey(name: "TypeCategory")]
        public Int64 TypeCategoryId { get; set; }

        public bool CategoryMappingIsActive { get; set; }

        public DateTime? CategoryMappingCreatedDate { get; set; }

        public DateTime? CategoryMappingChangeDate { get; set; }

        public Int64? CategoryChangeBy { get; set; }
    }
}
