using Rips.Backend.src.core.entities;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.infra.Map
{
    public class AHMap : Imap<AH>
    {
        public AH Map(string[] input)
        {
            return MappingHandler.ProcessMapping(

                ()=>
                {
                    InvoiceNumber invoiceNumber = new InvoiceNumber(input[0]);
                    CodeHealthProvider healthProvider = new CodeHealthProvider(input[1]);
                    IdentificationType identificationType = new IdentificationType(input[2]);
                    IdentificationNumber identificationNumber = new IdentificationNumber(input[3]);
                    RouteEntryToInstitution routeEntryToInstitution = new RouteEntryToInstitution(input[4]);
                    Date dateIncomeUserToInstitution = new Date(input[5]);
                    Hour hourIcomeUserToInstitution = new Hour(input[6]);
                    AutorizationNumber autorizationNumber = new AutorizationNumber(input[7]);
                    ExternalCause externalCause = new ExternalCause(input[8]);
                    Diagnosis diagnosisMainIncome = new Diagnosis(input[9]);
                    Diagnosis diagnosisMainEgress = new Diagnosis(input[10]);
                    Diagnosis diagnosisRelatedEgress1 = new Diagnosis(input[11]);
                    Diagnosis diagnosisRelatedEgress2 = new Diagnosis(input[12]);
                    Diagnosis diagnosisRelatedEgress3 = new Diagnosis(input[13]);
                    Diagnosis diagnosisComplication = new Diagnosis(input[14]);
                    StateToExit stateToExit = new StateToExit(input[15]);
                    Diagnosis diagnosisBasicCauseOfDeath = new Diagnosis(input[16]);
                    Date dateEgressUserInstitution = new Date(input[17]);
                    Hour egressTimeUserOfTheInstitution = new Hour(input[18]);

                    return new AH(
                        invoiceNumber,
                        healthProvider,
                        identificationType,
                        identificationNumber,
                        routeEntryToInstitution,
                        dateIncomeUserToInstitution,
                        hourIcomeUserToInstitution,
                        autorizationNumber,
                        externalCause,
                        diagnosisMainIncome,
                        diagnosisMainEgress,
                        diagnosisRelatedEgress1,
                        diagnosisRelatedEgress2,
                        diagnosisRelatedEgress3,
                        diagnosisComplication,
                        stateToExit,
                        diagnosisBasicCauseOfDeath,
                        dateEgressUserInstitution,
                        egressTimeUserOfTheInstitution
                        );
                });
        }
    }
}
