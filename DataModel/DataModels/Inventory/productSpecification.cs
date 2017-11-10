using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DataModel.DataModels.Inventory
{
    public class ProductSpecification : MasterDM
    {
        [Key]
        public int ProductSpecificationID { get; set; }

        public int ProductID { get; set; }

        public int ProductSpecificationsID { get; set; }

        public int ProductSpecificationValuesID { get; set; }

        public bool ProductSpecificationISActive { get; set; }

        public DateTime? ProductSpecificationCreatedDate { get; set; }

        public DateTime? ProductSpecificationChangeDate { get; set; }

        public int ProductSpecificationChangeBy { get; set; }        
    }
}
