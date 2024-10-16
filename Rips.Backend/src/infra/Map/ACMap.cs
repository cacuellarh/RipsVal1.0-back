using Rips.Backend.src.core.entities;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.infra.Map
{
    public class ACMap : Imap<AC>
    {
        public AC Map(string[] input)
        {
            InvoiceNumber invoiceNumber = new InvoiceNumber(input[0]);
            CodeHealthProvider codeHealthProvider = new CodeHealthProvider(input[1]);
            IdentificationType identificationType = new IdentificationType(input[2]);
            IdentificationNumber identificationNumber = new IdentificationNumber(input[3]);
            Date consultationDate = new Date(input[4]);
            AutorizationNumber autorizationNumber = new AutorizationNumber(input[5]);
            ConsultationCode consultationCode = new ConsultationCode(input[6]);
            PurposeConsultation purposeConsultation = new PurposeConsultation(input[7]);
            ExternalCause externalCause = new ExternalCause(input[8]);
            CodeDiagnosisMajor codeDiagnosisMajor = new CodeDiagnosisMajor(input[9]);
            CodeRelatedDiagnostic codeRelatedDiagnostic1 = new CodeRelatedDiagnostic(input[10]);
            CodeRelatedDiagnostic codeRelatedDiagnostic2 = new CodeRelatedDiagnostic(input[11]);
            CodeRelatedDiagnostic codeRelatedDiagnostic3 = new CodeRelatedDiagnostic(input[12]);
            TypeDiagnosisMajor typeDiagnosisMajor = new TypeDiagnosisMajor(input[13]);  
            PriceValue valueConsult = new PriceValue(input[14]);
            PriceValue valueShareModerator = new PriceValue(input[15]);
            PriceValue totalValue = new PriceValue(input[15]);

            return new AC(invoiceNumber,
                codeHealthProvider,
                identificationType,
                identificationNumber,
                consultationDate,
                autorizationNumber,
                consultationCode,
                purposeConsultation,
                externalCause,
                codeDiagnosisMajor,
                codeRelatedDiagnostic1,
                codeRelatedDiagnostic2,
                codeRelatedDiagnostic3,
                typeDiagnosisMajor,
                valueConsult,
                valueShareModerator,
                totalValue
                );
        }
    }
}
