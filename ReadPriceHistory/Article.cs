namespace ReadPriceHistory
{
    public class Article
    {
        public string EanCode { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly StopDate { get; set; }
        public Double Price { get; set; }

        public Article(string eanCode, DateOnly dtStart, DateOnly dtStop, Double price)
        {
            if (String.IsNullOrEmpty(eanCode))
                throw new ArgumentNullException(nameof(eanCode));
            if (dtStart == DateOnly.MaxValue)
                throw new ArgumentOutOfRangeException(nameof(dtStart));
            if (dtStop == DateOnly.MinValue)
                throw new ArgumentOutOfRangeException(nameof(dtStop));
            if (dtStart > dtStop)
                throw new ArgumentOutOfRangeException(nameof(dtStart) + "," + nameof(dtStop));
            if (price <= 0)
                throw new ArgumentOutOfRangeException(nameof(price));

            StartDate = dtStart;
            StopDate = dtStop;
            EanCode = eanCode;
            Price = price;
        }
    }
}