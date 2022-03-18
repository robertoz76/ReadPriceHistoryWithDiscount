using ReadPriceHistory;
using System;
using Xunit;


namespace ReadPriceHistoryTest
{

    public class DiscountTests
    {

        // articolo con ean string o null
        // articolo con data inizio > data fine
        // articolo con data inizio = data fine
        // articolo con data inizio Mindate
        // articolo con data fine  Maxdate
        // articolo prezzo a zero o negativo 


        [Fact]
        public void D_EanCodeIsNullOrEmpty_false()
        {
            var dt1 = new DateOnly(2022, 10, 30);
            var dt2 = new DateOnly(2022, 12, 31);
            Assert.Throws<ArgumentNullException>(() => new Discount(null, dt1, dt2, Discount.DiscountValue.D10));
        }

        [Fact]
        public void D_EanCodeIsEmptyOrNull_false()
        {
            var dt1 = new DateOnly(2022, 10, 30);
            var dt2 = new DateOnly(2022, 12, 31);
            Assert.Throws<ArgumentNullException>(() => new Discount(null, dt1, dt2, Discount.DiscountValue.D15));
        }

        [Fact]
        public void D_DtStartGtDtStop_false()
        {
            var dt1 = new DateOnly(2022, 10, 21);
            var dt2 = new DateOnly(2022, 10, 20);
            Assert.Throws<ArgumentOutOfRangeException>(() => new Discount("1234", dt1, dt2, Discount.DiscountValue.D15));
        }

        [Fact]
        public void D_DtStartEqDtStopAreNormalDate_true()
        {
            var dt1 = new DateOnly(2022, 10, 20);
            var dt2 = dt1;
            var art = new Discount("1234", dt1, dt2, Discount.DiscountValue.D15);
            Assert.NotNull(art);
            Assert.Equal("1234", art.EanCode);
            Assert.Equal(Discount.DiscountValue.D15, art.Value);
            Assert.Equal(new DateOnly(2022, 10, 20), art.StartDiscount);
            Assert.Equal(new DateOnly(2022, 10, 20), art.StopDiscount);
        }

        [Fact]
        public void D_DtStartEqDtStopAreMinValue_false()
        {
            var dt1 = DateOnly.MinValue;
            var dt2 = dt1;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Discount("1234", dt1, dt2, Discount.DiscountValue.D15));
        }

        [Fact]
        public void D_DtStartEqDtStopAreMaxValue_false()
        {
            var dt1 = DateOnly.MaxValue;
            var dt2 = dt1;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Discount("1234", dt1, dt2, Discount.DiscountValue.D15));
        }

        [Fact]
        public void D_DtStartOnlyIsMinValue_true()
        {
            var dt1 = DateOnly.MinValue;
            var dt2 = new DateOnly(2022, 10, 20);
            var art = new Discount("1234", dt1, dt2, Discount.DiscountValue.D15);
            Assert.NotNull(art);
            Assert.Equal("1234", art.EanCode);
            Assert.Equal(Discount.DiscountValue.D15, art.Value);
            Assert.Equal(DateOnly.MinValue, art.StartDiscount);
            Assert.Equal(new DateOnly(2022, 10, 20), art.StopDiscount);
        }

        [Fact]
        public void D_DtStopIsMaxValue_true()
        {
            var dt1 = new DateOnly(2022, 10, 20);
            var dt2 = DateOnly.MaxValue;
            var art = new Discount("1234", dt1, dt2, Discount.DiscountValue.D15);
            Assert.NotNull(art);
            Assert.Equal("1234", art.EanCode);
            Assert.Equal(Discount.DiscountValue.D15, art.Value);
            Assert.Equal(new DateOnly(2022, 10, 20), art.StartDiscount);
            Assert.Equal(DateOnly.MaxValue, art.StopDiscount);
        }
    }
}
