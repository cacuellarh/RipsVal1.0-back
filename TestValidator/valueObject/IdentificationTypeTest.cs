using Rips.Backend.src.core.valueObjects;

namespace TestValidator.valueObject
{
    [TestClass]
    public class IdentificationTypeTest
    {
        [TestMethod]
        public void CreateIdentificationTypeWithValidInput()
        {
            var name = "CC";

            var result = new IdentificationType(name);
            Assert.IsNotNull(result);
            Assert.AreEqual(name, result.Value);
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void CreateProviderNameTestWithInvalidInput()
        {
            var name = "CCC";

            var result = new IdentificationType(name);
            Assert.IsNull(result);
            Assert.AreEqual(name, result.Value);
        }

    }
}
