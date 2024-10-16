using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.attributes;
using Rips.Backend.src.core.interfaces;
using Rips.Backend.src.core.valueObjects;

namespace Rips.Backend.src.core.entities
{
    [ColumnLengthRequired(4)]
    public class CT : IFileRip
    {
        public CT(CodeHealthProvider codeProvider, Date submissionDate, string fileCode, string totalRecords)
        {
            NanisGuardV.validation.NotNullOrEmpty(fileCode);
            NanisGuardV.validation.NotNullOrEmpty(totalRecords);
            NanisGuardV.validation.ValidateParseStringToInt(totalRecords);

            CodeProvider = codeProvider;
            SubmissionDate = submissionDate;
            FileCode = fileCode;
            TotalRecords = totalRecords;
        }

        public CodeHealthProvider CodeProvider { get; private set;}
        public Date SubmissionDate { get; private set;}
        public string FileCode { get; private set;} 
        public string TotalRecords { get; private set;}

    }
}
