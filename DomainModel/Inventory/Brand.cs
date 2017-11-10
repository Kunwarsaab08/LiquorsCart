using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiquorsCart.ServerSide.DomainModel.Inventory
{
    public class Brand : MasterDM
    {
        public Company  CompanyId { get; set; }

        [Key]
        public int BrandId { get; set; }

        public string BrandName { get; set; }

        public string BrandDescription { get; set; }

        public SeoRepository BrandSEOId { get; set; }

        public ImageRepository BrandImageId { get; set; }

        public bool BrandIsMenu { get; set; }

        public bool BrandIsActive { get; set; }

        public DateTime? BrandCreatedDate { get; set; }

        public DateTime? BrandChangeDate { get; set; }

        public int BrandChangeby { get; set; }
    }
}
