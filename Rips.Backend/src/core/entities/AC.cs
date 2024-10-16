using Rips.Backend.src.core.attributes;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.core.entities
{
    [ColumnLengthRequired(17)]
    public class AC : IFileRip
    {
        public AC(InvoiceNumber invoiceNumber,
            CodeHealthProvider codeHealthProvider,
            IdentificationType identificationType,
            IdentificationNumber identificationNumber,
            Date consultationDate,
            AutorizationNumber autorizationNumber,
            ConsultationCode consultationCode,
            PurposeConsultation purposeConsultation,
            ExternalCause externalCause,
            CodeDiagnosisMajor codeDiagnosisMajor,
            CodeRelatedDiagnostic codeRelatedDiagnostic1,
            CodeRelatedDiagnostic codeRelatedDiagnostic2,
            CodeRelatedDiagnostic codeRelatedDiagnostic3,
            TypeDiagnosisMajor typeDiagnosisMajor,
            PriceValue valueConsult,
            PriceValue valueShareModerator,
            PriceValue totalValue)
        {
            InvoiceNumber = invoiceNumber;
            CodeHealthProvider = codeHealthProvider;
            IdentificationType = identificationType;
            IdentificationNumber = identificationNumber;
            ConsultationDate = consultationDate;
            AutorizationNumber = autorizationNumber;
            ConsultationCode = consultationCode;
            PurposeConsultation = purposeConsultation;
            ExternalCause = externalCause;
            CodeDiagnosisMajor = codeDiagnosisMajor;
            CodeRelatedDiagnostic1 = codeRelatedDiagnostic1;
            CodeRelatedDiagnostic2 = codeRelatedDiagnostic2;
            CodeRelatedDiagnostic3 = codeRelatedDiagnostic3;
            TypeDiagnosisMajor = typeDiagnosisMajor;
            ValueConsult = valueConsult;
            ValueShareModerator = valueShareModerator;
            TotalValue = totalValue;
        }

        public InvoiceNumber InvoiceNumber { get; private set; }
        public CodeHealthProvider CodeHealthProvider { get; private set; }
        public IdentificationType IdentificationType { get; private set; }
        public IdentificationNumber IdentificationNumber { get; private set; }
        public Date ConsultationDate { get; private set; }
        public AutorizationNumber AutorizationNumber { get; private set; }
        public ConsultationCode ConsultationCode { get; private set; }
        public PurposeConsultation PurposeConsultation { get; private set; }
        public ExternalCause ExternalCause { get; private set; }
        public CodeDiagnosisMajor CodeDiagnosisMajor { get; private set; }
        public CodeRelatedDiagnostic CodeRelatedDiagnostic1 { get; private set; }
        public CodeRelatedDiagnostic CodeRelatedDiagnostic2 { get; private set; }
        public CodeRelatedDiagnostic CodeRelatedDiagnostic3 { get; private set; }
        public TypeDiagnosisMajor TypeDiagnosisMajor { get; private set;}
        public PriceValue ValueConsult { get; private set; }
        public PriceValue ValueShareModerator { get; private set; }
        public PriceValue TotalValue { get; private set; }
    }
}
