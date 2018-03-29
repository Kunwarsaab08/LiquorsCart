using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class SubCategory : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 SubCategoryId { get; set; }

        [Required]
        [StringLength(30)]
        public string SubCategoryName { get; set; }

        [StringLength(100)]
        public string SubCategoryDescription { get; set; }

        [ForeignKey(name: "SeoRepository")]
        public Int64 SubCategorySEOId { get; set; }

        [ForeignKey(name: "ImageRepository")]
        public Int64 SubCategoryImageId { get; set; }

        [Required]
        public bool SubCategoryIsParent { get; set; }

        public Int64 SubCategoryParentId { get; set; }

        [Required]
        public bool SubCategoryIsMenu { get; set; }

        [Required]
        public bool SubCategoryIsActive { get; set; }

        public DateTime? SubCategoryCreatedDate { get; set; }

        public DateTime? SubCategoryChangeDate { get; set; }

        public Int64? SubCategoryChangeBy { get; set; }
    }
}
