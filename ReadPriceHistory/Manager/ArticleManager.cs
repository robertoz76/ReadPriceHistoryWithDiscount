using ReadPriceHistory.Abstractions;

namespace ReadPriceHistory.Manager
{
    public class ArticleManager : IArticleManager
    {
        public Article GetArticle(string eanCode, DateOnly date)
        {
            throw new NotImplementedException();
        }

        public void InsertArticle(string eanCode, DateOnly starDate, DateOnly endDate, double price)
        {
            throw new NotImplementedException();
        }

        public bool RangeArticleFree(string eanCode, DateOnly starDate, DateOnly endDate)
        {
            throw new NotImplementedException();
        }
    }
}
