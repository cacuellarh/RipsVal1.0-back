using Rips.Backend.src.core.entities;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.infra.Map
{
    public class ATMap : Imap<AT>
    {
        public AT Map(string[] input)
        {
            return MappingHandler.ProcessMapping(
                () =>
                    {
                        InvoiceNumber invoiceNumber = new InvoiceNumber(input[0]);
                        CodeHealthProvider healthProvider = new CodeHealthProvider(input[1]);
                        IdentificationNumber identificationNumber = new IdentificationNumber(input[2]);
                        AutorizationNumber autorizationNumber = new AutorizationNumber(input[3]);
                        ServiceType serviceType = new ServiceType(input[4]);
                        string? codeService = input[5];
                        string? serviceName = input[6];
                        string? cuantity = input[7];
                        PriceValue unitValue = new PriceValue(input[8]);
                        PriceValue totalValue = new PriceValue(input[9]);

                        return new AT(
                            invoiceNumber,
                            healthProvider,
                            identificationNumber,
                            autorizationNumber,
                            serviceType,
                            codeService,
                            serviceName,
                            cuantity,
                            unitValue,
                            totalValue
                            );
                    }
                );
        }
    }
}
