using QTMvc5Shop.Data.Infrastructure;
using QTMvc5Shop.Model.Models;

namespace QTMvc5Shop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}