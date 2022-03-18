using Xunit;

namespace ReadPriceHistoryTest
{
    public class ArticleTests
    {

        // articolo null
        // articolo con ean string o null
        // articolo con data inizio > data fine
        // articolo con data inizio = data fine
        // articolo con data inizio Mindate
        // articolo con data fine  Maxdate
        // articolo prezzo a zero o negativo 
        // prezzo con range date già coperto da altri prezzi

        [Fact]
        public void A_DtStartGtDtStop_false()
        {

        }

        [Fact]
        public void A_DtStartEqDtStop_false()
        {

        }

        [Fact]
        public void A_DtStartIsMinValue_true()
        {

        }

        [Fact]
        public void A_DtStopIsMaxValue_true()
        {

        }

        [Fact]
        public void A_PriceZeroOrNegative_false()
        {

        }

    }
}