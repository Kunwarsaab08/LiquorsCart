using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModels.Inventory
{
    public class company
    {
        public int companyId { get; set; }

        public string companyName { get; set; }

        public string companyDescription { get; set; }

        public int companySEOId { get; set; }

        public int companyImageId { get; set; }

        public bool companyIsMenu { get; set; }

        public bool companyIsActive { get; set; }

        public DateTime companyCreatedDate { get; set; }

        public DateTime? companyChangeDate { get; set; }

        public int companyChangeBy { get; set; }
    }
}
