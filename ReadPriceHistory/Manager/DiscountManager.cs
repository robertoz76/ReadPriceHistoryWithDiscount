using ReadPriceHistory.Abstractions;

namespace ReadPriceHistory.Manager
{
    public class DiscountManager : IDiscountManager
    {
        public bool RangeDiscountFree(string eanCode, DateOnly starDiscount, DateOnly endDiscount)
        {
            return true;
        }
    }
}
