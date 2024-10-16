
using Rips.Backend.src.core.valueObjects;

namespace TestValidator.valueObject
{
    [TestClass]
    public class IdentificationNumberTest
    {
        [TestMethod]
        public void CreateIdentificationNumberWithValidInput()
        {
            var name = "1022414866";

            var result = new IdentificationNumber(name);
            Assert.IsNotNull(result);
        }
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void CreateIdentificationNumberWithInvalidLength()
        {
            var name = "123456789123456789";

            var result = new IdentificationType(name);
            Assert.IsNull(result);
            Assert.AreEqual(name, result.Value);
        }

    }
}
