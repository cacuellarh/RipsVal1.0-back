using Rips.Backend.src.core.configuration;
using Rips.Backend.src.core.domainService;
using Rips.Backend.src.core.entities;
using Rips.Backend.src.core.file;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.infra.FileReader;
using Rips.Backend.src.infra.Map;

namespace TestValidator.services
{
    [TestClass]
    public class ValidateStructureServiceTest
    {
        [TestMethod]
        public void ValidateStructureServiceWithValidCT()
        {
            Imap<CT> _map = new CTMap();
            IColumnLengthRequiredRegister _fileRipConfiguration = new ColumnLengthRequiredRegister();
            IFileFlatReader _fileFlatReader = new FileFlatReader();

            IValidateStructureService validator = new ValidateStructureService<CT>(_map, _fileRipConfiguration, _fileFlatReader);

            var result = validator.ValidateFileRip(@"C:\Users\camil\OneDrive\Desktop\escritorio\Proyectos\RIPS\CT000170\CT000170.txt");

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Errors.Count);
        }

        [TestMethod]
        public void ValidateStructureServiceWithValidAC()
        {
            Imap<US> _map = new USMap();
            IColumnLengthRequiredRegister _fileRipConfiguration = new ColumnLengthRequiredRegister();
            IFileFlatReader _fileFlatReader = new FileFlatReader();

            IValidateStructureService validator = new ValidateStructureService<US>(_map, _fileRipConfiguration, _fileFlatReader);

            var result = validator.ValidateFileRip(@"C:\Users\camil\OneDrive\Desktop\escritorio\Proyectos\RIPS\CT000170\US000170.txt");

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Errors.Count);
        }
    }
}
