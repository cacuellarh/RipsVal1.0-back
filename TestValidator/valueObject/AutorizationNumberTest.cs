using Rips.Backend.src.core.valueObjects;

namespace TestValidator.valueObject
{
    [TestClass]
    public class AutorizationNumberTest
    {
        [TestMethod]
        public void CreateAutorizationNumberExpectedException()
        {
            string number = "345345";

            var result = new AutorizationNumber(number);

            Assert.IsNotNull(result);
        }
    }
}
