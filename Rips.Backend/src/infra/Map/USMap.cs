using Rips.Backend.src.core.file;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;
namespace Rips.Backend.src.infra.Map

{
    public class USMap : Imap<US>
    {
        public US Map(string[] input)
        {
            return MappingHandler.ProcessMapping(() =>
            {
                IdentificationType userIdentificationType = new IdentificationType(input[0]);
                IdentificationNumber userIdentificationNumber = new IdentificationNumber(input[1]);
                CodeAdministratorEntity codeAdministratorEntity = new CodeAdministratorEntity(input[2]);
                UserType userType = new UserType(input[3]);
                string firtsNameUser = input[4];
                string secondNameUser = input[5];
                string firtsLastNameUser = input[6];
                string secondLastNameUser = input[7];
                Age age = new Age(input[8]);
                UnitOfMeasurement unitOfMeasurement = new UnitOfMeasurement(input[9]);
                Sex sex = new Sex(input[10]);
                string departamentCode = input[11];
                string municipalityCode = input[12];
                string residenceArea = input[13];

                return new US(userIdentificationType,
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
            });

        }
    }
}
