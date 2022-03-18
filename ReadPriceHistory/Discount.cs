namespace ReadPriceHistory
{
    public class Discount
    {

        public string EanCode { get; set; }
        public DiscountValue Value { get; set; }
        public DateOnly StartDiscount { get; set; }
        public DateOnly StopDiscount { get; set; }
        public Discount()
        {
            StartDiscount = DateOnly.MinValue;
            StopDiscount = DateOnly.MaxValue;
        }


        //[0,5,10,15,20,25,30,35,40,45,50]
        public enum DiscountValue
        {
            D00 = 0,
            D05 = 1,
            D10 = 2,
            D15 = 3,
            D20 = 4,
            D25 = 5,
            D30 = 6,
            D35 = 7,
            D40 = 8,
            D45 = 9,
            D50 = 10
        }
    }


}

