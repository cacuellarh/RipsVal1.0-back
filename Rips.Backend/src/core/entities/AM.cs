using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.attributes;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.core.entities
{
    [ColumnLengthRequired(14)]
    public class AM : IFileRip
    {
        public AM(InvoiceNumber invoiceNumber,
            CodeHealthProvider healthProvider,
            IdentificationType identificationType,
            IdentificationNumber identificationNumber,
            AutorizationNumber autorizationNumber,
            MedicationCode medicationCode,
            string medicationName,
            string shapePharmaceutical,
            string concentrationMedicine,
            string unitMeasureMedicine,
            int numberOfUnit,
            PriceValue unitValueMedicine,
            PriceValue totalValue)
        {
            NanisGuardV.validation.NotNullOrEmpty(medicationName);
            NanisGuardV.validation.NotNullOrEmpty(shapePharmaceutical);
            NanisGuardV.validation.NotNullOrEmpty(concentrationMedicine);
            NanisGuardV.validation.NotNullOrEmpty(unitMeasureMedicine);
            NanisGuardV.validation.NotNullOrEmpty(numberOfUnit);
            InvoiceNumber = invoiceNumber;
            HealthProvider = healthProvider;
            IdentificationType = identificationType;
            IdentificationNumber = identificationNumber;
            AutorizationNumber = autorizationNumber;
            MedicationCode = medicationCode;
            MedicationName = medicationName;
            ShapePharmaceutical = shapePharmaceutical;
            ConcentrationMedicine = concentrationMedicine;
            UnitMeasureMedicine = unitMeasureMedicine;
            NumberOfUnit = numberOfUnit;
            UnitValueMedicine = unitValueMedicine;
            TotalValue = totalValue;
        }

        public InvoiceNumber InvoiceNumber { get; private set; }
        public CodeHealthProvider HealthProvider { get; private set; }
        public IdentificationType IdentificationType { get; private set; }
        public IdentificationNumber IdentificationNumber { get; private set; }
        public AutorizationNumber AutorizationNumber { get; private set;}
        public MedicationCode MedicationCode { get; private set; }
        public string MedicationName { get; private set; }
        public string ShapePharmaceutical { get; private set; }
        public string ConcentrationMedicine { get; private set; }
        public string UnitMeasureMedicine { get; private set; }
        public int NumberOfUnit { get; private set; }
        public PriceValue UnitValueMedicine { get; private set; }
        public PriceValue TotalValue { get; private set; }
    }
}
