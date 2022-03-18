namespace ReadPriceHistory.Abstractions
{
    public interface IArticleManager
    {
        bool RangeArticleFree(string eanCode, DateOnly starDate, DateOnly endDate);
    }
}
