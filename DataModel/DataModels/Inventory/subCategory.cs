using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModels.Inventory
{
    public class subCategory
    {
        public int subCategoryId { get; set; }

        public string subCategoryName { get; set; }

        public string subCategoryDescription { get; set; }

        public int subCategorySEOId { get; set; }

        public int subCategoryImageId { get; set; }

        public bool subCategoryIsParent { get; set; }

        public int subCategoryParentId { get; set; }

        public bool subCategoryIsMenu { get; set; }

        public bool subCategoryIsActive { get; set; }

        public DateTime subCategoryCreatedDate { get; set; }

        public DateTime? subCategoryChangeDate { get; set; }

        public int subCategoryChangeBy { get; set; }
    }
}
