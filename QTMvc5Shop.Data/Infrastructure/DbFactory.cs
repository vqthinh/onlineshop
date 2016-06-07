namespace QTMvc5Shop.Data.Infrastructure
{
    public class DbFactory:Disposable,IDbFactory
    {
        private QTMvc5ShopDbContext dbContext;
        public QTMvc5ShopDbContext Init()
        {
            return dbContext ?? (dbContext = new QTMvc5ShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
