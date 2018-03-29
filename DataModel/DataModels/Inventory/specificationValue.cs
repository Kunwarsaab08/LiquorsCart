using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class SpecificationValue : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 SpecificationValueId { get; set; }

        [Required]
        [StringLength(50)]
        public string SpecificationDesc { get; set; }

        [Required]
        public bool  SpecificationValuesIsActive { get; set; }

        public DateTime? SpecificationValueCreatedDate { get; set; }

        public DateTime? SpecificationValueChangeDate { get; set; }

        public Int64? SpecificationValueChangeBy { get; set; }

    }
}
