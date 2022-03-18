using ReadPriceHistory;
using System;
using Xunit;

namespace ReadPriceHistoryTest
{
    public class ArticleTests
    {
        // articolo con ean string o null
        // articolo con data inizio > data fine
        // articolo con data inizio = data fine
        // articolo con data inizio Mindate
        // articolo con data fine  Maxdate
        // articolo prezzo a zero o negativo 
        // prezzo con range date già coperto da altri prezzi

        [Fact]
        public void A_EanCodeIsEmptyOrNull_false()
        {
            var dt1 = new DateOnly(2022, 10, 30);
            var dt2 = new DateOnly(2022, 12, 31);
            Assert.Throws<ArgumentNullException>(() => new Article(null, dt1, dt2, 1.50));
        }

        [Fact]
        public void A_DtStartGtDtStop_false()
        {
            var dt1 = new DateOnly(2022, 10, 21);
            var dt2 = new DateOnly(2022, 10, 20);
            Assert.Throws<ArgumentOutOfRangeException>(() => new Article("1234", dt1, dt2, 1.50));
        }

        [Fact]
        public void A_DtStartEqDtStopAreNormalDate_true()
        {
            var dt1 = new DateOnly(2022, 10, 20);
            var dt2 = dt1;
            var art = new Article("1234", dt1, dt2, 1.50);
            Assert.NotNull(art);
            Assert.Equal("1234", art.EanCode);
            Assert.Equal(1.5, art.Price);
            Assert.Equal(new DateOnly(2022, 10, 20), art.StartDate);
            Assert.Equal(new DateOnly(2022, 10, 20), art.StopDate);
        }

        [Fact]
        public void A_DtStartEqDtStopAreMinValue_false()
        {
            var dt1 = DateOnly.MinValue;
            var dt2 = dt1;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Article("1234", dt1, dt2, 1.50));
        }

        [Fact]
        public void A_DtStartEqDtStopAreMaxValue_false()
        {
            var dt1 = DateOnly.MaxValue;
            var dt2 = dt1;
            Assert.Throws<ArgumentOutOfRangeException>(() => new Article("1234", dt1, dt2, 1.50));
        }

        [Fact]
        public void A_DtStartOnlyIsMinValue_true()
        {
            var dt1 = DateOnly.MinValue;
            var dt2 = new DateOnly(2022, 10, 20);
            var art = new Article("1234", dt1, dt2, 1.50);
            Assert.NotNull(art);
            Assert.Equal("1234", art.EanCode);
            Assert.Equal(1.5, art.Price);
            Assert.Equal(DateOnly.MinValue, art.StartDate);
            Assert.Equal(new DateOnly(2022, 10, 20), art.StopDate);
        }

        [Fact]
        public void A_DtStopIsMaxValue_true()
        {
            var dt1 = new DateOnly(2022, 10, 20);
            var dt2 = DateOnly.MaxValue;
            var art = new Article("1234", dt1, dt2, 1.50);
            Assert.NotNull(art);
            Assert.Equal("1234", art.EanCode);
            Assert.Equal(1.5, art.Price);
            Assert.Equal(new DateOnly(2022, 10, 20), art.StartDate);
            Assert.Equal(DateOnly.MaxValue, art.StopDate);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void A_PriceZeroOrNegative_false(Double price)
        {
            var dt1 = new DateOnly(2022, 10, 30);
            var dt2 = new DateOnly(2022, 12, 31);
            Assert.Throws<ArgumentOutOfRangeException>(() => new Article("1234", dt1, dt2, price));

        }

    }
}