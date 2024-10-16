using Rips.Backend.src.core.attributes;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.core.entities
{
    [ColumnLengthRequired(11)]
    public class AT : IFileRip
    {
        public AT(InvoiceNumber invoiceNumber,
            CodeHealthProvider healthProvider,
            IdentificationNumber identificationNumber,
            AutorizationNumber autorizationNumber,
            ServiceType serviceType,
            string? codeService,
            string? serviceName,
            string? cuantity,
            PriceValue unitValue,
            PriceValue totalValue)
        {
            InvoiceNumber = invoiceNumber;
            HealthProvider = healthProvider;
            IdentificationNumber = identificationNumber;
            AutorizationNumber = autorizationNumber;
            ServiceType = serviceType;
            CodeService = codeService;
            ServiceName = serviceName;
            Cuantity = cuantity;
            UnitValue = unitValue;
            TotalValue = totalValue;
        }

        public InvoiceNumber InvoiceNumber { get; private set; }
        public CodeHealthProvider HealthProvider { get; private set; }
        public IdentificationNumber IdentificationNumber { get; private set; }
        public AutorizationNumber AutorizationNumber { get; private set; }
        public ServiceType ServiceType { get; private set; }
        public string? CodeService { get; private set; } = string.Empty;
        public string? ServiceName { get; private set; } = string.Empty;
        public string? Cuantity { get; private set;} = string.Empty;
        public PriceValue UnitValue { get; private set; }
        public PriceValue TotalValue { get; private set; }
    }
}
