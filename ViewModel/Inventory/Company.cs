using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.ViewModel.Inventory
{
    public class Company : MasterDM
    {
        public Int64 CompanyId { get; set; }

        public string CompanyName { get; set; }

        public string CompanyDescription { get; set; }

        public SeoRepository CompanySEOId { get; set; }

        public ImageRepository CompanyImageId { get; set; }

        public bool CompanyIsMenu { get; set; }

        public bool CompanyIsActive { get; set; }

        public DateTime? CompanyCreatedDate { get; set; }

        public DateTime? CompanyChangeDate { get; set; }

        public Int64? CompanyChangeBy { get; set; }
    }
}
