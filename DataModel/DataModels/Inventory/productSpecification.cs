using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataModel.DataModels.Inventory
{
    public class ProductSpecification : MasterDM
    {
        [Key]
        public int ProductSpecificationID { get; set; }

        public Product ProductID { get; set; }

        public Specification ProductSpecificationsID { get; set; }

        public int ProductSpecificationValuesID { get; set; }

        public bool ProductSpecificationISActive { get; set; }

        public DateTime? ProductSpecificationCreatedDate { get; set; }

        public DateTime? ProductSpecificationChangeDate { get; set; }

        public int ProductSpecificationChangeBy { get; set; }        
    }
}
