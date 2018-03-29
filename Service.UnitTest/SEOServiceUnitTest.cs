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
    public class SEOServiceUnitTest:Profile
    {
        public SEOServiceUnitTest()
        {
            MapperProfilesConfiguration.Configure();
        }

        [TestMethod]
        public void SEORepoGetByID()
        {
            try
            {
                Int64 id = 1;
                VM.SeoRepository seorepo = new VM.SeoRepository();
                GenericService<VM.SeoRepository> seoService = new GenericService<VM.SeoRepository>();
                seorepo = seoService.GetById(id);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void SEORepoDelete()
        {
            try
            {
                Int64 id = 2;
                GenericService<VM.SeoRepository> seoService = new GenericService<VM.SeoRepository>();
                seoService.Delete(id);                 
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }            
        }

        [TestMethod]
        public void SEORepoInsert()
        {
            try
            {
                VM.SeoRepository seorepo = new VM.SeoRepository
                {
                    SeoKeywords = "Test7",
                    SeoDescriptionTag = "Test7",
                    SeoMetaTag = "Test7",
                    SeoPageTitle = "Test7"
                };

                GenericService<VM.SeoRepository> seoService = new GenericService<VM.SeoRepository>();
                seoService.Insert(seorepo);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void SEORepoUdate()
        {
            try
            {
                VM.SeoRepository seorepo = new VM.SeoRepository
                {
                    SeoId = 2,
                    SeoKeywords = "Test8",
                    SeoDescriptionTag = "Test8",
                    SeoMetaTag = "Test8",
                    SeoPageTitle = "Test8"
                };

                GenericService<VM.SeoRepository> seoService = new GenericService<VM.SeoRepository>();
                seoService.Update(seorepo);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
