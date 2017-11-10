using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DomainModel.Inventory
{
    public class Specification : MasterDM
    {
        [Key]
        public int SpecificationID { get; set; }

        public string SpecificationDescription { get; set; }

        public bool SpecificationIsActive { get; set; }

        public DateTime? SpecificationCreatedDate { get; set; }

        public DateTime? SpecificationChangedDate { get; set; }

        public int SpecificationChangeBy { get; set; }
    }
}
