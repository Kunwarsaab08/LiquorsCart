using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using DataModel;
using DataModel.DataModels.Inventory;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.UnitTest
{
    [TestClass]
    public class categoryRepoTest
    {
        private GenericUOW unitOfWork = new GenericUOW();
        private GenericRepository<Category> categoryRepo;

        [TestMethod]
        public void getAllCategory_Test()
        {
            categoryRepo = unitOfWork.GenericRepository<Category>();
            IEnumerable<Category> categories;
            categories =  categoryRepo.FindAll();
        }
    }
}
