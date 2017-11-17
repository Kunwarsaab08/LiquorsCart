using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class TypeCategory : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 TypeCategoryId { get; set; }

        [Required]
        [StringLength(30)]
        public string TypeCategoryName { get; set; }

        [StringLength(100)]
        public string TypeCategoryDescription { get; set; }

        [ForeignKey(name: "SeoRepository")]
        public Int64 TypeCategorySEOId { get; set; }

        [ForeignKey(name: "ImageRepository")]
        public Int64 TypeCategoryImageId { get; set; }

        [Required]
        public bool TypeCategoryIsParent { get; set; }

        public Int64 TypeCategoryParentId { get; set; }

        [Required]
        public bool TypeCategoryIsMenu { get; set; }

        [Required]
        public bool TypeCategoryIsActive { get; set; }

        public DateTime? TypeCategoryCreatedDate { get; set; }

        public DateTime? TypeCategoryChangeDate { get; set; }

        public int TypeCategoryChangeBy { get; set; }
    }
}
