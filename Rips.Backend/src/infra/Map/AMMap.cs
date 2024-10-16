using Rips.Backend.src.core.entities;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;
using NanisGuard;
using NanisGuard.src;
namespace Rips.Backend.src.infra.Map
{
    public class AMMap : Imap<AM>
    {
        public AM Map(string[] input)
        {
            return MappingHandler.ProcessMapping(
                () =>
                {

                    InvoiceNumber invoiceNumber = new InvoiceNumber(input[0]);
                    CodeHealthProvider healthProvider = new CodeHealthProvider(input[1]);
                    IdentificationType identificationType = new IdentificationType(input[2]);
                    IdentificationNumber identificationNumber = new IdentificationNumber(input[3]);
                    AutorizationNumber autorizationNumber = new AutorizationNumber(input[4]);
                    MedicationCode medicationCode = new MedicationCode(input[5]);
                    string medicationName = input[6];
                    string shapePharmaceutical = input[7];
                    string concentrationMedicine = input[8];
                    string unitMeasureMedicine = input[9];
                    int numberOfUnit = NanisGuardV.validation.ValidateParseStringToInt(input[10], nameof(numberOfUnit));
                    PriceValue unitValueMedicine = new PriceValue(input[11]);
                    PriceValue totalValue = new PriceValue(input[10]);

                    return new AM(
                            invoiceNumber,
                            healthProvider,
                            identificationType,
                            identificationNumber,
                            autorizationNumber,
                            medicationCode,
                            medicationName,
                            shapePharmaceutical,
                            concentrationMedicine,
                            unitMeasureMedicine,
                            numberOfUnit,
                            unitValueMedicine,
                            totalValue
                        );
                });
        }
    }
}
