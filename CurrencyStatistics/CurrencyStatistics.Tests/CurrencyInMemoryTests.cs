namespace CurrencyStatistics.Tests
{
    public class CurrencyInMemoryTests
    {
        [Test]
        public void ReturnCorrectMinValue()
        {
            //arrange
            var currency = new CurrencyInMemory("Euro");
            currency.AddValues(1);
            currency.AddValues("21");
            currency.AddValues(3.0f);

            //act
            var result = currency.GetStatistics();

            //assert
            Assert.AreEqual(1f, result.Min);

        }

        [Test]
        public void ReturnCorrectMaxValue()
        {
            //arrange
            var currency = new CurrencyInMemory("Euro");
            currency.AddValues(2.0f);
            currency.AddValues("4");
            currency.AddValues("100");

            //act
            var result = currency.GetStatistics();

            //assert
            Assert.AreEqual(100f, result.Max);

        }

        [Test]
        public void ReturnCorrectAverageValue()
        {
            //arrange
            var currency = new CurrencyInMemory("Euro");
            currency.AddValues(2);
            currency.AddValues(2);
            currency.AddValues(6);

            //act
            var result = currency.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(result.Average, 2));

        }

    }
}