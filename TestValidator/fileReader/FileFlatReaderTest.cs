using Rips.Backend.src.infra.FileReader;

namespace TestValidator.fileReader
{
    [TestClass]
    public class FileFlatReaderTest
    {
        [TestMethod]
        public void ReadFileWithValidPath()
        {
            var path = @"C:\Users\camil\OneDrive\Desktop\escritorio\Proyectos\RIPS\CT000170\CT000170.txt";

            var reader = new FileFlatReader();
            var result = reader.ReadFile(path);

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, 3);
        }

        [ExpectedException(typeof(FileNotFoundException))]
        [TestMethod]
        public void ReadFileWithInvalidPath()
        {
            var path = @"C:\Users\camil\OneDrive\Desktop\escritorio\Proyectos\RIPS\CT000170\CT000sd170.txt";

            var reader = new FileFlatReader();
            var result = reader.ReadFile(path);

            Assert.IsNull(result);
        }
    }
}
