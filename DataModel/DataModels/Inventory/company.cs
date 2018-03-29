using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class Company : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 CompanyId { get; set; }

        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }

        [StringLength(100)]
        public string CompanyDescription { get; set; }

        [ForeignKey(name: "SeoRepository")]
        public Int64 CompanySEOId { get; set; }

        [ForeignKey(name: "ImageRepository")]
        public Int64 CompanyImageId { get; set; }

        [Required]
        public bool CompanyIsMenu { get; set; }

        [Required]
        public bool CompanyIsActive { get; set; }

        public DateTime? CompanyCreatedDate { get; set; }

        public DateTime? CompanyChangeDate { get; set; }

        public Int64 CompanyChangeBy { get; set; }
    }
}
