namespace ReadPriceHistory.Abstractions
{
    public interface IDiscountManager
    {
        bool RangeDiscountFree(string eanCode, DateOnly starDiscount, DateOnly endDiscount);
    }
}
