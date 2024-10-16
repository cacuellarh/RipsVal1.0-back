using Rips.Backend.src.core.attributes;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.core.entities
{
    [ColumnLengthRequired(17)]
    public class AU : IFileRip
    {
        public AU(InvoiceNumber invoiceNumber,
            CodeHealthProvider health,
            IdentificationType identificationType,
            IdentificationNumber identificationNumber,
            Date dateIncomeUserObservation,
            Hour entryTimeFromUserToObservation,
            AutorizationNumber autorizationNumber,
            ExternalCause externalCause,
            Diagnosis outputDiagnosis,
            Diagnosis diagnosisRelated1,
            Diagnosis diagnosisRelated2,
            Diagnosis diagnosisRelated3,
            CauseOfDead causeOfDead,
            Date dateUserExit,
            Hour hourUserExit)
        {
            InvoiceNumber = invoiceNumber;
            Health = health;
            IdentificationType = identificationType;
            IdentificationNumber = identificationNumber;
            DateIncomeUserObservation = dateIncomeUserObservation;
            EntryTimeFromUserToObservation = entryTimeFromUserToObservation;
            AutorizationNumber = autorizationNumber;
            ExternalCause = externalCause;
            OutputDiagnosis = outputDiagnosis;
            DiagnosisRelated1 = diagnosisRelated1;
            DiagnosisRelated2 = diagnosisRelated2;
            DiagnosisRelated3 = diagnosisRelated3;
            CauseOfDead = causeOfDead;
            DateUserExit = dateUserExit;
            HourUserExit = hourUserExit;
        }

        public InvoiceNumber InvoiceNumber { get; set; }
        public CodeHealthProvider Health { get; set; }
        public IdentificationType IdentificationType { get; set; }
        public IdentificationNumber IdentificationNumber { get; set; }
        public Date DateIncomeUserObservation { get; private set; }
        public Hour EntryTimeFromUserToObservation { get; private set; }
        public AutorizationNumber AutorizationNumber { get; private set; }
        public ExternalCause ExternalCause { get; private set; }
        public Diagnosis OutputDiagnosis { get; private set; }
        public Diagnosis DiagnosisRelated1 { get; private set; }
        public Diagnosis DiagnosisRelated2 { get; private set; }
        public Diagnosis DiagnosisRelated3 { get; private set; }
        public CauseOfDead CauseOfDead { get; private set; }
        public Date DateUserExit { get; private set; }
        public Hour HourUserExit { get; private set; }
    }
}
