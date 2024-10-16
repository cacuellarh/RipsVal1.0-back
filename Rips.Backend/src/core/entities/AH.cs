using Rips.Backend.src.core.attributes;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.core.entities
{
    [ColumnLengthRequired(11)]
    public class AH : IFileRip
    {
        public AH(InvoiceNumber invoiceNumber,
            CodeHealthProvider healthProvider,
            IdentificationType identificationType,
            IdentificationNumber identificationNumber,
            RouteEntryToInstitution routeEntryToInstitution,
            Date dateIncomeUserToInstitution,
            Hour hourIcomeUserToInstitution,
            AutorizationNumber autorizationNumber,
            ExternalCause externalCause,
            Diagnosis diagnosisMainIncome,
            Diagnosis diagnosisMainEgress,
            Diagnosis diagnosisRelatedEgress1,
            Diagnosis diagnosisRelatedEgress2,
            Diagnosis diagnosisRelatedEgress3,
            Diagnosis diagnosisComplication,
            StateToExit stateToExit,
            Diagnosis diagnosisBasicCauseOfDeath,
            Date dateEgressUserInstitution,
            Hour egressTimeUserOfTheInstitution)
        {
            InvoiceNumber = invoiceNumber;
            HealthProvider = healthProvider;
            IdentificationType = identificationType;
            IdentificationNumber = identificationNumber;
            RouteEntryToInstitution = routeEntryToInstitution;
            DateIncomeUserToInstitution = dateIncomeUserToInstitution;
            HourIcomeUserToInstitution = hourIcomeUserToInstitution;
            AutorizationNumber = autorizationNumber;
            ExternalCause = externalCause;
            DiagnosisMainIncome = diagnosisMainIncome;
            DiagnosisMainEgress = diagnosisMainEgress;
            DiagnosisRelatedEgress1 = diagnosisRelatedEgress1;
            DiagnosisRelatedEgress2 = diagnosisRelatedEgress2;
            DiagnosisRelatedEgress3 = diagnosisRelatedEgress3;
            DiagnosisComplication = diagnosisComplication;
            StateToExit = stateToExit;
            DiagnosisBasicCauseOfDeath = diagnosisBasicCauseOfDeath;
            DateEgressUserInstitution = dateEgressUserInstitution;
            EgressTimeUserOfTheInstitution = egressTimeUserOfTheInstitution;
        }

        public InvoiceNumber InvoiceNumber { get; private set; }
        public CodeHealthProvider HealthProvider { get; private set; }
        public IdentificationType IdentificationType { get; private set; }
        public IdentificationNumber IdentificationNumber { get; private set; }
        public RouteEntryToInstitution RouteEntryToInstitution { get; private set; }
        public Date DateIncomeUserToInstitution { get; private set; }
        public Hour HourIcomeUserToInstitution { get; private set; }
        public AutorizationNumber AutorizationNumber { get; private set;}
        public ExternalCause ExternalCause { get; private set; }
        public Diagnosis DiagnosisMainIncome { get; private set; }
        public Diagnosis DiagnosisMainEgress { get; private set; }
        public Diagnosis DiagnosisRelatedEgress1 { get; private set; }
        public Diagnosis DiagnosisRelatedEgress2 { get; private set; }
        public Diagnosis DiagnosisRelatedEgress3 { get; private set; }
        public Diagnosis DiagnosisComplication { get; private set; }
        public StateToExit StateToExit { get; private set; }
        public Diagnosis DiagnosisBasicCauseOfDeath { get; private set; }
        public Date DateEgressUserInstitution { get; private set; }
        public Hour EgressTimeUserOfTheInstitution { get; private set; }
    }
}
