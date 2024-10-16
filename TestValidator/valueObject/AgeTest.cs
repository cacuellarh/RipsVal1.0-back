using Rips.Backend.src.core.valueObjects;

namespace TestValidator.valueObject
{
    [TestClass]
    public class AgeTest
    {
        [TestMethod]
        public void AgeCreateWithValidInput()
        {
            string age = "23";

            var result = new Age(age);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AgeCreateWithInvalidInput()
        {
            string age = "123";

            var result = new Age(age);

            Assert.IsNotNull(result);
        }
    }
}
