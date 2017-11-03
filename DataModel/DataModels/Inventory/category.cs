using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.DataModels.Inventory
{
    public class category : masterDM
    {
        public int categoryId { get; set; }

        public string categoryName { get; set; }

        public string categoryDescription { get; set; }

        public int categorySEOId { get; set; }

        public int  categoryImageId { get; set; }

        public bool categoryIsParent { get; set; }

        public int categoryParentId { get; set; }

        public bool categoryIsMenu { get; set; }

        public bool categoryIsActive { get; set; }

        public DateTime categoryCreatedDate { get; set; }

        public DateTime ? categoryChangeDate { get; set; }

        public int categoryChangeBy { get; set; }
    }
}
