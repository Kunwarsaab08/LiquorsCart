using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiquorsCart.ServerSide.Service;
using DM = LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using VM = LiquorsCart.ServerSide.ViewModel.Inventory;
using System;
using AutoMapper;
using LiquorsCart.ServerSide.Transformation;
namespace Service.UnitTest
{
    [TestClass]
    public class CompanyServiceUnitTest:Profile
    {
        public CompanyServiceUnitTest()
        {
            try
            {
                MapperProfilesConfiguration.Configure();
            }
            catch(Exception ex)
            {
                throw ex;
            }            
        }

        [TestMethod]
        public void CompanyRepoGet()
        {
            try
            {
                Int64 id = 1;
                GenericService<VM.Company> seoService = new GenericService<VM.Company>();
                var result = seoService.GetById(id);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void CompanyRepoInsert()
        {
            try
            {

                VM.Company vmCompany = new VM.Company
                {
                    CompanyName = "Jhony Walker",
                    CompanyDescription = "Jhony Walker Test",
                    CompanyIsActive = true,
                    CompanyIsMenu = true,
                    CompanyImageId = new VM.ImageRepository
                                    {
                                        ImageLargeUrl = "NA2",
                                        ImageSmallUrl = "NA2",
                                        ImageLogoIcon = "NA2"
                                    },
                    CompanySEOId = new VM.SeoRepository
                                    {
                                        SeoId = 1,
                                        SeoDescriptionTag = "JW2",
                                        SeoKeywords = "JW2",
                                        SeoMetaTag = "JW2",
                                        SeoPageTitle = "JW2"
                                    },
                    CompanyChangeBy = 1,
                    //CompanyChangeDate = System.DateTime.Now,
                    //CompanyCreatedDate=System.DateTime.Now
                };
                
                GenericService<VM.Company> companyService = new GenericService<VM.Company>();
                companyService.Insert(vmCompany);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
