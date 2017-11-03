using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModels.Inventory
{
    public class productSpecification
    {
        public int productSpecificationID { get; set; }

        public int productID { get; set; }

        public int productSpecificationsID { get; set; }

        public int productSpecificationValuesID { get; set; }

        public bool productSpecificationISActive { get; set; }

        public DateTime productSpecificationCreatedDate { get; set; }

        public DateTime? productSpecificationChangeDate { get; set; }

        public int productSpecificationChangeBy { get; set; }        
    }
}
