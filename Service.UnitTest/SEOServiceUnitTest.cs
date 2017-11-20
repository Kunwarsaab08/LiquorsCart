using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiquorsCart.ServerSide.Service;
using DM = LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using VM = LiquorsCart.ServerSide.ViewModel.Inventory;
using System;
using AutoMapper;

namespace Service.UnitTest
{
    [TestClass]
    public class SEOServiceUnitTest 
    {
        [TestMethod]
        public void SEORepoDelete()
        {
            try
            {
                Int64 id = 10002;
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
                VM.SeoRepository seorepo = new VM.SeoRepository();
                seorepo.SeoKeywords = "Test5";
                seorepo.SeoDescriptionTag = "Test5";
                seorepo.SeoMetaTag = "Test5";
                seorepo.SeoPageTitle = "Test5";
                
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
                VM.SeoRepository seorepo = new VM.SeoRepository();
                seorepo.SeoId = 50002;
                seorepo.SeoKeywords = "Test5";
                seorepo.SeoDescriptionTag = "Test5";
                seorepo.SeoMetaTag = "Test5";
                seorepo.SeoPageTitle = "Test5";

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
