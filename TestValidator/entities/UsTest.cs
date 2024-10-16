using Rips.Backend.src.core.file;
using Rips.Backend.src.core.valueObjects;

namespace TestValidator.entities
{
    [TestClass]
    public class UsTest
    {
        [TestMethod]
        public void CreateUsFileWithValidInput()
        {
            IdentificationType userIdentificationType = new IdentificationType("CC");
            IdentificationNumber userIdentificationNumber = new IdentificationNumber("124234234");
            CodeAdministratorEntity codeAdministratorEntity = new CodeAdministratorEntity("fre456");
            UserType userType = new UserType("1");
            string? firtsNameUser = "andres";
            string? secondNameUser = "felipe";
            string? firtsLastNameUser = "lopez";
            string? secondLastNameUser = "lopez";
            Age age = new Age("23");
            UnitOfMeasurement unitOfMeasurement = new UnitOfMeasurement("3");
            Sex sex = new Sex("M");
            string departamentCode = "234";
            string municipalityCode = "23423";
            string residenceArea = "U";

            var Us = new US(
                userIdentificationType,
                userIdentificationNumber,
                codeAdministratorEntity,
                userType,
                firtsNameUser,
                secondNameUser,
                firtsLastNameUser,
                secondLastNameUser,
                age,
                unitOfMeasurement,
                sex,
                departamentCode,
                municipalityCode,
                residenceArea
                );

            Assert.IsNotNull(Us);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateUsFileWithInvalidInput()
        {
            IdentificationType userIdentificationType = new IdentificationType("CC");
            IdentificationNumber userIdentificationNumber = new IdentificationNumber("124234234");
            CodeAdministratorEntity codeAdministratorEntity = new CodeAdministratorEntity("fre456");
            UserType userType = new UserType("1");
            string? firtsNameUser = "andres";
            string? secondNameUser = "felipe";
            string? firtsLastNameUser = "lopez";
            string? secondLastNameUser = "lopez";
            Age age = new Age("235");
            UnitOfMeasurement unitOfMeasurement = new UnitOfMeasurement("3");
            Sex sex = new Sex("M");
            string departamentCode = "234";
            string municipalityCode = "23423";
            string residenceArea = "U";

            var Us = new US(
                userIdentificationType,
                userIdentificationNumber,
                codeAdministratorEntity,
                userType,
                firtsNameUser,
                secondNameUser,
                firtsLastNameUser,
                secondLastNameUser,
                age,
                unitOfMeasurement,
                sex,
                departamentCode,
                municipalityCode,
                residenceArea
                );

            Assert.IsNotNull(Us);
        }
    }
}
