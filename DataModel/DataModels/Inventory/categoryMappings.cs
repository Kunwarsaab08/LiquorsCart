using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModels.Inventory
{
    public class categoryMappings
    {
        public int categoryMappingId { get; set; }

        public int mainCategoryId { get; set; }

        public int subCategoryId { get; set; }

        public int typeCategoryId { get; set; }

        public bool categoryMappingIsActive { get; set; }

        public DateTime categoryMappingCreatedDate { get; set; }

        public DateTime? categoryMappingChangeDate { get; set; }

        public int categoryChangeBy { get; set; }
    }
}
