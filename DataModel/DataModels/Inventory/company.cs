using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataModel.DataModels.Inventory
{
    public class Company : MasterDM
    {
        [Key]
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public string CompanyDescription { get; set; }

        public int CompanySEOId { get; set; }

        public int CompanyImageId { get; set; }

        public bool CompanyIsMenu { get; set; }

        public bool CompanyIsActive { get; set; }

        public DateTime? CompanyCreatedDate { get; set; }

        public DateTime? CompanyChangeDate { get; set; }

        public int CompanyChangeBy { get; set; }
    }
}
