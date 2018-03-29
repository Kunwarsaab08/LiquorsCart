using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;
using LiquorsCart.ServerSide.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.UnitTest
{
    [TestClass]
    public class categoryRepoTest
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private GenericRepository<SeoRepository> seoRepo;

        [TestMethod]
        public void getAllCategory_Test()
        {
            seoRepo = unitOfWork.GenericRepository<SeoRepository>();
            // get all models (all properties)

            List<SeoRepository> modelList =
               seoRepo.Get(m => m.SeoId == 50002);
           // SeoRepository modelList = seoRepo.GetById(1);
        }
    }
}
