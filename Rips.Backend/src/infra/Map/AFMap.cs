using Rips.Backend.src.core.entities;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.infra.Map
{
    public class AFMap : Imap<AF>
    {
        public AF Map(string[] input)
        {
            return MappingHandler.ProcessMapping(
                () =>
                {
                    CodeHealthProvider codeProvider = new CodeHealthProvider(input[0]);
                    ProviderName providerName = new ProviderName(input[1]);
                    IdentificationType identificationType = new IdentificationType(input[2]);
                    IdentificationNumber identificationNumber = new IdentificationNumber(input[3]);
                    InvoiceNumber invoiceNumber = new InvoiceNumber(input[4]);
                    Date expeditionDate = new Date(input[5]);
                    Date startDate = new Date(input[6]);
                    Date lastDate = new Date(input[7]);
                    string administrationProviderName = input[8];
                    string? contractNumber = input[9];
                    string? benefitsPlan = input[10];
                    string? policyNumber = input[11];
                    PriceValue copay = new PriceValue(input[12]);
                    PriceValue commission = new PriceValue(input[13]);
                    PriceValue discount = new PriceValue(input[14]);
                    PriceValue totalValue = new PriceValue(input[15]);

                    return new AF(
                        codeProvider,
                        providerName,
                        identificationType,
                        identificationNumber,
                        invoiceNumber,
                        expeditionDate,
                        startDate,
                        lastDate,
                        administrationProviderName,
                        contractNumber,
                        benefitsPlan,
                        policyNumber,
                        copay,
                        commission,
                        discount,
                        totalValue
                        );
                });
                
                
        }
    }
}
