using QTMvc5Shop.Data.Infrastructure;
using QTMvc5Shop.Model.Models;

namespace QTMvc5Shop.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {
    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}