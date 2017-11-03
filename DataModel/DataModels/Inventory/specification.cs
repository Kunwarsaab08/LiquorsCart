using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModels.Inventory
{
    public class specification
    {
        public int specificationID { get; set; }

        public string specificationDescription { get; set; }

        public bool specificationIsActive { get; set; }

        public DateTime specificationCreatedDate { get; set; }

        public DateTime? specificationChangedDate { get; set; }

        public int specificationChangeBy { get; set; }
    }
}
