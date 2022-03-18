namespace ReadPriceHistory
{
    public class Discount
    {

        public string EanCode { get; set; }
        public DiscountValue Value { get; set; }
        public DateOnly StartDiscount { get; set; }
        public DateOnly StopDiscount { get; set; }
        public Discount(string eanCode, DateOnly dtStartDiscount, DateOnly dtStopDiscount, DiscountValue discount)
        {
            if (String.IsNullOrEmpty(eanCode))
                throw new ArgumentNullException(nameof(eanCode));
            if (dtStartDiscount == DateOnly.MaxValue)
                throw new ArgumentOutOfRangeException(nameof(dtStartDiscount));
            if (dtStopDiscount == DateOnly.MinValue)
                throw new ArgumentOutOfRangeException(nameof(dtStopDiscount));
            if (dtStartDiscount > dtStopDiscount)
                throw new ArgumentOutOfRangeException(nameof(dtStartDiscount) + "," + nameof(dtStopDiscount));
            //if (discount <= 0)
            //    throw new ArgumentOutOfRangeException(nameof(discount));
            StartDiscount = dtStartDiscount;
            StopDiscount = dtStopDiscount;
            Value = discount;
            EanCode = eanCode;
        }


        //[0,5,10,15,20,25,30,35,40,45,50]

        public enum DiscountValue
        {
            D00 = 0,
            D05 = 5,
            D10 = 10,
            D15 = 15,
            D20 = 20,
            D25 = 25,
            D30 = 30,
            D35 = 35,
            D40 = 40,
            D45 = 45,
            D50 = 50
        }
    }


}

