using Rips.Backend.src.core.entities;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.infra.Map
{
    public class AUMap : Imap<AU>
    {
        public AU Map(string[] input)
        {
            return MappingHandler.ProcessMapping(
                () =>
                {
                    InvoiceNumber invoiceNumber = new InvoiceNumber(input[0]);
                    CodeHealthProvider health = new CodeHealthProvider(input[1]);
                    IdentificationType identificationType = new IdentificationType(input[2]);
                    IdentificationNumber identificationNumber = new IdentificationNumber(input[3]);
                    Date dateIncomeUserObservation = new Date(input[4]);
                    Hour entryTimeFromUserToObservation = new Hour(input[5]);
                    AutorizationNumber autorizationNumber = new AutorizationNumber(input[6]);
                    ExternalCause externalCause = new ExternalCause(input[7]);
                    Diagnosis outputDiagnosis = new Diagnosis(input[8]);
                    Diagnosis diagnosisRelated1 = new Diagnosis(input[9]);
                    Diagnosis diagnosisRelated2 = new Diagnosis(input[10]);
                    Diagnosis diagnosisRelated3 = new Diagnosis(input[11]);
                    CauseOfDead causeOfDead = new CauseOfDead(input[12]);
                    Date dateUserExit = new Date(input[13]);
                    Hour hourUserExit = new Hour(input[14]);

                    return new AU(
                        invoiceNumber,
                        health,
                        identificationType,
                        identificationNumber,
                        dateIncomeUserObservation,
                        entryTimeFromUserToObservation,
                        autorizationNumber,
                        externalCause,
                        outputDiagnosis,
                        diagnosisRelated1,
                        diagnosisRelated2,
                        diagnosisRelated3,
                        causeOfDead,
                        dateUserExit,
                        hourUserExit
                        );
                });

        }
    }
}
