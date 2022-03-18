namespace ReadPriceHistory
{
    public class Discount
    {


        public Article article { get; set; }
        public DiscountValue discount { get; set; }
        public DateOnly startDiscount { get; set; }
        public DateOnly stopDiscount { get; set; }


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

