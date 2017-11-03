using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using DataModel.DataModels.Inventory;
using System.Collections.Generic;

namespace Repository.UnitTest
{
    [TestClass]
    public class categoryRepoTest
    {
        private GenericUOW unitOfWork = new GenericUOW();
        private GenericRepository<category> categoryRepo;

        [TestMethod]
        public void getAllCategory_Test()
        {
            categoryRepo = unitOfWork.GenericRepository<category>();
            IEnumerable<category> categories = categoryRepo.Table;
        }
    }
}
