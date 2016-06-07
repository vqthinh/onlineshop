using System;

namespace QTMvc5Shop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        QTMvc5ShopDbContext Init();
    }
}