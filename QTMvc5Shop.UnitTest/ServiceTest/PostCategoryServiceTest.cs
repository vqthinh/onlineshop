using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using QTMvc5Shop.Data.Infrastructure;
using QTMvc5Shop.Data.Repositories;
using QTMvc5Shop.Model.Models;
using QTMvc5Shop.Service;

namespace QTMvc5Shop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categoryService;
        private List<PostCategory> _listCategories;
        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listCategories = new List<PostCategory>()
            {
                new PostCategory() {ID=1,Name="Category 1",Status = true},
                new PostCategory() {ID=2,Name="Category 2",Status = true}

            };
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //Set up method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategories);
            var result = _categoryService.GetAll() as List<PostCategory>;

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count,5);
        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {

        }
    }
}
