namespace ReadPriceHistory
{
    public class Article
    {
        public string EanCode { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly StopDate { get; set; }
        public Double Price { get; set; }

    }
}