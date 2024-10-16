using Rips.Backend.src.core.entities;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.infra.Map
{
    public class APMap : Imap<AP>
    {
        public AP Map(string[] input)
        {
            return MappingHandler.ProcessMapping(
                () =>
                {
                    InvoiceNumber invoiceNumber = new InvoiceNumber(input[0]);
                    CodeHealthProvider codeHealthProvider = new CodeHealthProvider(input[1]);
                    IdentificationType identificationType = new IdentificationType(input[2]);
                    IdentificationNumber identificationNumber = new IdentificationNumber(input[3]);
                    Date procedureDate = new Date(input[4]);
                    AutorizationNumber autorizationNumber = new AutorizationNumber(input[5]);
                    ConsultationCode procedureCode = new ConsultationCode(input[6]);
                    ScopeRealizationProcedure scopeRealizationProcedure = new ScopeRealizationProcedure(input[7]);
                    PurposeProcedure purposeProcedure = new PurposeProcedure(input[8]);
                    PersonnelWhoAttends personnelWhoAttends = new PersonnelWhoAttends(input[9]);
                    Diagnosis principalDiagnosis = new Diagnosis(input[10]);
                    Diagnosis diagnosisRelated = new Diagnosis(input[11]);
                    Diagnosis complication = new Diagnosis(input[12]);
                    ShapeRealizationActSurgical shapeRealizationActSurgical = new ShapeRealizationActSurgical(input[13]);
                    PriceValue procedureValue = new PriceValue(input[14]);

                    return new AP(
                        invoiceNumber,
                        codeHealthProvider,
                        identificationType,
                        identificationNumber,
                        procedureDate,
                        autorizationNumber,
                        procedureCode,
                        scopeRealizationProcedure,
                        purposeProcedure,
                        personnelWhoAttends,
                        principalDiagnosis,
                        diagnosisRelated,
                        complication,
                        shapeRealizationActSurgical,
                        procedureValue
                        );
                }
                );
        }
    }
}
