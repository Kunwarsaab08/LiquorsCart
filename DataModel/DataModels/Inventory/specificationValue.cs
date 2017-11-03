using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModels.Inventory
{
    public class specificationValue
    {
        public int specificationValueId { get; set; }

        public string specificationDesc { get; set; }

        public bool  specificationValuesIsActive { get; set; }

        public DateTime specificationValueCreatedDate { get; set; }

        public DateTime? specificationValueChangeDate { get; set; }

        public int specificationValueChangeBy { get; set; }

    }
}
