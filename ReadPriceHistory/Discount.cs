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
        public class DiscountValue
        {
            public const string D00 = nameof(D00);
            public const string D05 = nameof(D05);
            public const string D10 = nameof(D10);
            public const string D15 = nameof(D15);
            public const string D20 = nameof(D20);
            public const string D25 = nameof(D25);
            public const string D30 = nameof(D30);
            public const string D35 = nameof(D35);
            public const string D40 = nameof(D40);
            public const string D45 = nameof(D45);
            public const string D50 = nameof(D50);
        }
    }


}

