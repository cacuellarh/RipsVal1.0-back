using Rips.Backend.src.core.entities;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.infra.Map
{
    public class ANMap : Imap<AN>
    {
        public AN Map(string[] input)
        {
            return MappingHandler.ProcessMapping(
                () => 
                {
                    InvoiceNumber invoiceNumber = new InvoiceNumber(input[0]);
                    CodeHealthProvider healthProvider = new CodeHealthProvider(input[1]);
                    IdentificationType identificationTypeMother = new IdentificationType(input[2]);
                    IdentificationNumber identificationNumberMother = new IdentificationNumber(input[3]);
                    Date dateBirthNewBorn = new Date(input[4]);
                    Age gestationalAge = new Age(input[5]);
                    PrenatalControl prenatalControl = new PrenatalControl(input[6]);
                    Sex sex = new Sex(input[7]);
                    Weight weight = new Weight(input[8]);
                    Diagnosis diagnosisNewBorn = new Diagnosis(input[9]);
                    CauseOfDead causeOfDead = new CauseOfDead(input[10]);
                    Date dateOfDeath = new Date(input[11]);
                    Hour hourOfDeath = new Hour(input[12]);

                    return new AN(
                        invoiceNumber,
                        healthProvider,
                        identificationTypeMother,
                        identificationNumberMother,
                        dateBirthNewBorn,
                        gestationalAge,
                        prenatalControl,
                        sex,
                        weight,
                        diagnosisNewBorn,
                        causeOfDead,
                        dateOfDeath,
                        hourOfDeath
                        );
                }
                );
        }
    }
}
