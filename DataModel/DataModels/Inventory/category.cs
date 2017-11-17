using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class Category : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 CategoryId { get; set; }

        [Required]
        [StringLength(30)]
        public string CategoryName { get; set; }

        [StringLength(100)]
        public string CategoryDescription { get; set; }

        [ForeignKey(name: "SeoRepository")]
        public int CategorySEOId { get; set; }

        [ForeignKey(name: "ImageRepository")]
        public int  CategoryImageId { get; set; }

        [Required]
        public bool CategoryIsParent { get; set; }

        public Int64 CategoryParentId { get; set; }

        [Required]
        public bool CategoryIsMenu { get; set; }

        [Required]
        public bool CategoryIsActive { get; set; }

        public DateTime? CategoryCreatedDate { get; set; }

        public DateTime? CategoryChangeDate { get; set; }

        public int CategoryChangeBy { get; set; }
    }
}
