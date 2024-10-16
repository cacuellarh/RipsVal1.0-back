using Rips.Backend.src.core.attributes;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.core.entities
{
    [ColumnLengthRequired(17)]
    public class AF : IFileRip
    {
        public AF(CodeHealthProvider codeProvider,
            ProviderName providerName,
            IdentificationType identificationType,
            IdentificationNumber identificationNumber,
            InvoiceNumber invoiceNumber,
            Date expeditionDate,
            Date startDate,
            Date lastDate,
            string administrationProviderName,
            string? contractNumber,
            string? benefitsPlan,
            string? policyNumber,
            PriceValue copay,
            PriceValue commission,
            PriceValue discount,
            PriceValue totalValue)
        {
            CodeProvider = codeProvider;
            ProviderName = providerName;
            IdentificationType = identificationType;
            IdentificationNumber = identificationNumber;
            InvoiceNumber = invoiceNumber;
            ExpeditionDate = expeditionDate;
            StartDate = startDate;
            LastDate = lastDate;
            AdministrationProviderName = administrationProviderName;
            ContractNumber = contractNumber;
            BenefitsPlan = benefitsPlan;
            PolicyNumber = policyNumber;
            Copay = copay;
            Commission = commission;
            Discount = discount;
            TotalValue = totalValue;
        }

        public CodeHealthProvider CodeProvider { get; private set;}
        public ProviderName ProviderName { get; private set; }
        public IdentificationType IdentificationType { get; private set; }
        public IdentificationNumber IdentificationNumber { get; private set; }
        public InvoiceNumber InvoiceNumber { get; private set; }
        public Date ExpeditionDate { get; private set; }
        public Date StartDate { get; private set; }
        public Date LastDate { get; private set; }
        public string AdministrationProviderName { get; private set; }
        public string? ContractNumber { get; private set; } = string.Empty;
        public string? BenefitsPlan { get; private set; } = string.Empty;
        public string? PolicyNumber { get; private set; } = string.Empty;
        public PriceValue Copay { get; private set; }
        public PriceValue Commission { get; private set; }
        public PriceValue Discount { get; private set; }
        public PriceValue TotalValue { get; private set; }
    }
}
