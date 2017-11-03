using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModels.Inventory
{
    public class typeCategory
    {
        public int typeCategoryId { get; set; }

        public string typeCategoryName { get; set; }

        public string typeCategoryDescription { get; set; }

        public int typeCategorySEOId { get; set; }

        public int typeCategoryImageId { get; set; }

        public bool typeCategoryIsParent { get; set; }

        public int typeCategoryParentId { get; set; }

        public bool typeCategoryIsMenu { get; set; }

        public bool typeCategoryIsActive { get; set; }

        public DateTime typeCategoryCreatedDate { get; set; }

        public DateTime? typeCategoryChangeDate { get; set; }

        public int typeCategoryChangeBy { get; set; }
    }
}
