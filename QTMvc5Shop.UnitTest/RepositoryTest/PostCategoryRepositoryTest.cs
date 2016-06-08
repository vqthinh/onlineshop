using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QTMvc5Shop.Data.Infrastructure;
using QTMvc5Shop.Data.Repositories;
using QTMvc5Shop.Model.Models;

namespace QTMvc5Shop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository postCategoryRepository;
        IUnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            postCategoryRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "test-category";
            category.Status = true;

            var result = postCategoryRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.ID);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = postCategoryRepository.GetAll().ToList();

            Assert.AreEqual(3, list.Count);
        }
    }
}
