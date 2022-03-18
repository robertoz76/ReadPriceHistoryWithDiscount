using ReadPriceHistory.Abstractions;

namespace ReadPriceHistory.Manager
{
    public class ArticleManager : IArticleManager
    {
        public bool RangeArticleFree(string eanCode, DateOnly starDate, DateOnly endDate)
        {
            return true;
        }
    }
}
