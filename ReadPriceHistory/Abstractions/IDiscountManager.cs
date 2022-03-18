namespace ReadPriceHistory.Abstractions
{
    public interface IDiscountManager
    {
        void InsertDiscount(string eanCode, DateOnly starDiscount, DateOnly endDiscount);
    }
}
