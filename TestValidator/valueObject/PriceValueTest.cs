using Rips.Backend.src.core.valueObjects;

namespace TestValidator.valueObject
{
    [TestClass]
    public class PriceValueTest
    {
        [TestMethod]
        public void CreatePriceValueWithValidInput()
        {
            var name = "123123";

            var result = new PriceValue(name);
            Assert.IsNotNull(result);
        }
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void CreatePriceValueWithNegative()
        {
            var name = "-4645";

            var result = new PriceValue(name);
            Assert.IsNull(result);
        }
    }
}
