using Rips.Backend.src.core.valueObjects;

namespace TestValidator.valueObject
{
    [TestClass]
    public class SexTest
    {
        [TestMethod]
        public void SexCreateWithValidInput()
        {
            string sex = "M";

            var result = new Sex(sex);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SexCreateWithInvalidInput()
        {
            string sex = "NM";

            var result = new Sex(sex);

            Assert.IsNull(result);
        }

    }
}
