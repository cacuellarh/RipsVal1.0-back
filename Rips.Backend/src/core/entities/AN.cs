using Rips.Backend.src.core.attributes;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.core.entities
{
    [ColumnLengthRequired(14)]
    public class AN : IFileRip
    {
        public AN(InvoiceNumber invoiceNumber,
            CodeHealthProvider healthProvider,
            IdentificationType identificationTypeMother,
            IdentificationNumber identificationNumberMother,
            Date dateBirthNewBorn,
            Age gestationalAge,
            PrenatalControl prenatalControl,
            Sex sex,
            Weight weight,
            Diagnosis diagnosisNewBorn,
            CauseOfDead causeOfDead,
            Date dateOfDeath,
            Hour hourOfDeath)
        {
            InvoiceNumber = invoiceNumber;
            HealthProvider = healthProvider;
            IdentificationTypeMother = identificationTypeMother;
            IdentificationNumberMother = identificationNumberMother;
            DateBirthNewBorn = dateBirthNewBorn;
            GestationalAge = gestationalAge;
            PrenatalControl = prenatalControl;
            Sex = sex;
            Weight = weight;
            DiagnosisNewBorn = diagnosisNewBorn;
            CauseOfDead = causeOfDead;
            DateOfDeath = dateOfDeath;
            HourOfDeath = hourOfDeath;
        }

        public InvoiceNumber InvoiceNumber { get; private set; }
        public CodeHealthProvider HealthProvider { get; private set; }
        public IdentificationType IdentificationTypeMother { get; private set; }
        public IdentificationNumber IdentificationNumberMother { get; private set; }
        public Date DateBirthNewBorn { get; private set; }
        public Age  GestationalAge { get; private set; }
        public PrenatalControl PrenatalControl { get; private set; }
        public Sex Sex { get; private set; }
        public Weight Weight { get; private set; }
        public Diagnosis DiagnosisNewBorn { get; private set; }
        public CauseOfDead CauseOfDead { get; private set; }
        public Date DateOfDeath { get; private set; }
        public Hour HourOfDeath { get; private set; }
    }
}
