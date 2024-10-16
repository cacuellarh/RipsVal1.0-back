using Rips.Backend.src.core.attributes;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.core.entities
{
    [ColumnLengthRequired(15)]
    public class AP : IFileRip
    {
        public AP(InvoiceNumber invoiceNumber,
            CodeHealthProvider codeHealthProvider,
            IdentificationType identificationType,
            IdentificationNumber identificationNumber,
            Date procedureDate,
            AutorizationNumber autorizationNumber,
            ConsultationCode procedureCode,
            ScopeRealizationProcedure scopeRealizationProcedure,
            PurposeProcedure purposeProcedure,
            PersonnelWhoAttends personnelWhoAttends,
            Diagnosis principalDiagnosis,
            Diagnosis diagnosisRelated,
            Diagnosis complication,
            ShapeRealizationActSurgical shapeRealizationActSurgical,
            PriceValue procedureValue)
        {
            InvoiceNumber = invoiceNumber;
            CodeHealthProvider = codeHealthProvider;
            IdentificationType = identificationType;
            IdentificationNumber = identificationNumber;
            ProcedureDate = procedureDate;
            AutorizationNumber = autorizationNumber;
            ProcedureCode = procedureCode;
            this.scopeRealizationProcedure = scopeRealizationProcedure;
            PurposeProcedure = purposeProcedure;
            this.personnelWhoAttends = personnelWhoAttends;
            PrincipalDiagnosis = principalDiagnosis;
            DiagnosisRelated = diagnosisRelated;
            Complication = complication;
            ShapeRealizationActSurgical = shapeRealizationActSurgical;
            ProcedureValue = procedureValue;
        }

        public InvoiceNumber InvoiceNumber { get; private set; }
        public CodeHealthProvider CodeHealthProvider { get; private set; }
        public IdentificationType IdentificationType { get; private set; }
        public IdentificationNumber IdentificationNumber { get; private set; }
        public Date ProcedureDate { get; private set; }
        public AutorizationNumber AutorizationNumber { get; private set;}
        public ConsultationCode ProcedureCode { get; private set;}
        public ScopeRealizationProcedure scopeRealizationProcedure { get; private set; }
        public PurposeProcedure PurposeProcedure { get; private set; }
        public PersonnelWhoAttends personnelWhoAttends { get; private set; }
        public Diagnosis PrincipalDiagnosis { get; private set; }
        public Diagnosis DiagnosisRelated { get; private set; }
        public Diagnosis Complication { get; private set; }
        public ShapeRealizationActSurgical ShapeRealizationActSurgical { get; private set; }
        public PriceValue ProcedureValue { get; private set; }


    }
}
