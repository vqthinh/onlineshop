using QTMvc5Shop.Data.Infrastructure;
using QTMvc5Shop.Model.Models;

namespace QTMvc5Shop.Data.Repositories
{
    public interface IOrderRepository  : IRepository<Order>
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}