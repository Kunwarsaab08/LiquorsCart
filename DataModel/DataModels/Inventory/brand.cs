using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class Brand : MasterDM
    {
        [Required]
        [ForeignKey(name: "Company")]
        public Int64  CompanyId { get; set; }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 BrandId { get; set; }

        [Required]
        [StringLength(30)]
        public string BrandName { get; set; }

        [StringLength(100)]
        public string BrandDescription { get; set; }

        [ForeignKey(name: "SeoRepository")]
        public Int64 BrandSEOId { get; set; }

        [ForeignKey(name: "ImageRepository")]
        public Int64 BrandImageId { get; set; }
        
        [Required]
        public bool BrandIsMenu { get; set; }

        [Required]
        public bool BrandIsActive { get; set; }

        public DateTime? BrandCreatedDate { get; set; }

        public DateTime? BrandChangeDate { get; set; }

        public int BrandChangeby { get; set; }
    }
}
