using QTMvc5Shop.Data.Infrastructure;
using QTMvc5Shop.Model.Models;

namespace QTMvc5Shop.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}