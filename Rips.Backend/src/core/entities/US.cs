
using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.attributes;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.core.file
{
    [ColumnLengthRequired(14)]
    public class US : IFileRip
    {
        public US(IdentificationType userIdentificationType,
            IdentificationNumber userIdentificationNumber,
            CodeAdministratorEntity codeAdministratorEntity,
            UserType userType,
            string? firtsNameUser,
            string? secondNameUser,
            string? firtsLastNameUser,
            string? secondLastNameUser,
            Age age,
            UnitOfMeasurement unitOfMeasurement,
            Sex sex,
            string departamentCode,
            string municipalityCode,
            string residenceArea)
        {
            NanisGuardV.validation.NotNullOrEmpty(departamentCode);
            NanisGuardV.validation.NotNullOrEmpty(municipalityCode);
            NanisGuardV.validation.NotNullOrEmpty(residenceArea);

            var departamentCodeParseToInt = NanisGuardV.validation.ValidateParseStringToInt(departamentCode);
            var municipalityCodeParseToInt = NanisGuardV.validation.ValidateParseStringToInt(municipalityCode);
            NanisGuardV.validation.StringRequiredLength(residenceArea, 1);

            UserIdentificationType = userIdentificationType;
            UserIdentificationNumber = userIdentificationNumber;
            CodeAdministratorEntity = codeAdministratorEntity;
            UserType = userType;
            FirtsNameUser = firtsNameUser;
            SecondNameUser = secondNameUser;
            FirtsLastNameUser = firtsLastNameUser;
            SecondLastNameUser = secondLastNameUser;
            Age = age;
            UnitOfMeasurement = unitOfMeasurement;
            Sex = sex;
            DepartamentCode = departamentCodeParseToInt;
            this.municipalityCode = municipalityCodeParseToInt;
            ResidenceArea = residenceArea;
        }

        public IdentificationType UserIdentificationType { get; private set; }
        public IdentificationNumber  UserIdentificationNumber { get; private set; }
        public CodeAdministratorEntity CodeAdministratorEntity { get; private set; }
        public UserType UserType { get; private set; }
        public string? FirtsNameUser { get; private set; } = string.Empty;
        public string? SecondNameUser { get; private set; } = string.Empty;
        public string? FirtsLastNameUser { get; private set; } = string.Empty;
        public string? SecondLastNameUser { get; private set; } = string.Empty;
        public Age Age { get; private set; }
        public UnitOfMeasurement UnitOfMeasurement { get; private set; }
        public Sex Sex { get; private set; }
        public int DepartamentCode { get; private set; }
        public int municipalityCode { get; private set; }
        public string ResidenceArea { get; private set; }

    }
}
