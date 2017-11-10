using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DomainModel.Inventory
{
    public class ProductSpecification : MasterDM
    {
        [Key]
        public int ProductSpecificationID { get; set; }

        public Product ProductID { get; set; }

        public Specification ProductSpecificationsID { get; set; }

        public SpecificationValue ProductSpecificationValuesID { get; set; }

        public bool ProductSpecificationISActive { get; set; }

        public DateTime? ProductSpecificationCreatedDate { get; set; }

        public DateTime? ProductSpecificationChangeDate { get; set; }

        public int ProductSpecificationChangeBy { get; set; }        
    }
}
