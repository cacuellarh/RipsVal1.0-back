using Rips.Backend.src.core.valueObjects;

namespace TestValidator.valueObject
{
    [TestClass]
    public class ProviderNameTest
    {
        [TestMethod]
        public void CreateProviderNameTestWithValidInput()
        {
            var name = "camilo";

            var result = new ProviderName(name);
            Assert.IsNotNull(result);
            Assert.AreEqual(name, result.Value);
        }
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void CreateProviderNameTestWithInvalidInput()
        {
            var name = "";

            var result = new ProviderName(name);
            Assert.IsNull(result);
            Assert.AreEqual(name, result.Value);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void CreateProviderNameTestWithDigit()
        {
            var name = "camilo5";

            var result = new ProviderName(name);
            Assert.IsNull(result);
        }
    }
}
