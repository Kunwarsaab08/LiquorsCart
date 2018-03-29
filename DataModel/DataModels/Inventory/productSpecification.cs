using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class ProductSpecification : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 ProductSpecificationID { get; set; }

        [Required]
        [ForeignKey(name: "Product")]
        public Int64 ProductID { get; set; }

        [Required]
        [ForeignKey(name: "Specification")]
        public Int64 ProductSpecificationsID { get; set; }

        [Required]
        [ForeignKey(name: "SpecificationValue")]
        public Int64 ProductSpecificationValuesID { get; set; }

        [Required]
        public bool ProductSpecificationISActive { get; set; }

        public DateTime? ProductSpecificationCreatedDate { get; set; }

        public DateTime? ProductSpecificationChangeDate { get; set; }

        public Int64? ProductSpecificationChangeBy { get; set; }        
    }
}
