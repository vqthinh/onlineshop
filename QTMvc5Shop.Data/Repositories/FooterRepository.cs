using QTMvc5Shop.Data.Infrastructure;
using QTMvc5Shop.Model.Models;

namespace QTMvc5Shop.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}