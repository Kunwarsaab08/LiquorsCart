using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataModel.DataModels.Inventory
{
    public class SpecificationValue : MasterDM
    {
        [Key]
        public int SpecificationValueId { get; set; }

        public Specification SpecificationDesc { get; set; }

        public bool  SpecificationValuesIsActive { get; set; }

        public DateTime? SpecificationValueCreatedDate { get; set; }

        public DateTime? SpecificationValueChangeDate { get; set; }

        public int SpecificationValueChangeBy { get; set; }

    }
}
