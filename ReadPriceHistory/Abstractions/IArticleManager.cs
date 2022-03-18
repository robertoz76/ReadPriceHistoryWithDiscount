namespace ReadPriceHistory.Abstractions
{
    public interface IArticleManager
    {
        void InsertArticle(string eanCode, DateOnly starDate, DateOnly endDate, Double price);
        bool RangeArticleFree(string eanCode, DateOnly starDate, DateOnly endDate);

        Article GetArticle(string eanCode, DateOnly date);

        // Article Article(string eanCode, DateOnly date);

    }
}
