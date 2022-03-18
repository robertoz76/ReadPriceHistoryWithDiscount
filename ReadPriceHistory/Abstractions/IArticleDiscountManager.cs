namespace ReadPriceHistory.Abstractions
{
    public interface IArticleDiscountManager
    {
        ArticleDiscount GetArticleDiscount(string eanCode, DateOnly date);
    }
}
