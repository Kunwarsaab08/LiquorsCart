using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class Specification : MasterDM
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 SpecificationID { get; set; }

        [Required]
        [StringLength(50)]
        public string SpecificationDescription { get; set; }

        [Required]
        public bool SpecificationIsActive { get; set; }

        public DateTime? SpecificationCreatedDate { get; set; }

        public DateTime? SpecificationChangedDate { get; set; }

        public Int64? SpecificationChangeBy { get; set; }
    }
}
