using ReadPriceHistory.Abstractions;

namespace ReadPriceHistory.Manager
{
    public class ArticleDiscountManager : IArticleDiscountManager
    {
        public ArticleDiscount GetArticleDiscount(string eanCode, DateOnly date)
        {
            throw new NotImplementedException();
        }
    }
}
