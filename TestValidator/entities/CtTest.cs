
using Rips.Backend.src.core.entities;
using Rips.Backend.src.core.valueObjects;

namespace TestValidator.entities
{
    [TestClass]
    public class CtTest
    {
        [TestMethod]
        public void CreateCTWithValidInput()
        {
            var code = new CodeHealthProvider("123123123122");
            var date = new Date("23/06/2028");
            string fileCode = "asda45454d";
            string totalRecords = "167";

            var ct = new CT(code, date, fileCode, totalRecords);

            Assert.IsNotNull(ct);
            Assert.AreEqual(code, ct.CodeProvider);
            Assert.AreEqual(date, ct.SubmissionDate);
        }
        [ExpectedException(typeof(FormatException))]
        [TestMethod]
        public void CreateCTWithInvalidCodeHealthInput()
        {
            var code = new CodeHealthProvider("123123d123122");
            var date = new Date("23/06/2028");
            string fileCode = "asda45454d";
            string totalRecords = "167";

            var ct = new CT(code, date, fileCode, totalRecords);

            Assert.IsNotNull(ct);
            Assert.AreEqual(code, ct.CodeProvider);
            Assert.AreEqual(date, ct.SubmissionDate);
        }
    }
}
