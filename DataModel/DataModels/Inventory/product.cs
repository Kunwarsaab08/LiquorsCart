using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class Product : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 ProductId { get; set; }

        [Required]
        [StringLength(30)]
        public string ProductName { get; set; }

        [StringLength(100)]
        public string ProductDescription { get; set; }

        [ForeignKey(name: "SeoRepository")]
        public Int64 ProductSEOId { get; set; }

        [ForeignKey(name: "ImageRepository")]
        public Int64 ProductImageId { get; set; }

        [Required]
        public bool ProductIsActive { get; set; }

        [Required]
        public bool ProductIsMenu { get; set; }

        public DateTime? ProductCreatedDate { get; set; }

        public DateTime? ProductChangedDate { get; set; }

        public int ProductChangedBy { get; set; }
    }
}
