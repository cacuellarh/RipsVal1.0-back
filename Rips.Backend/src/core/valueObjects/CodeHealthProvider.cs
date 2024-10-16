
using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class CodeHealthProvider : ValueObject
    {
        public long Code { get; private set; }
        public CodeHealthProvider(string code) 
        {
            long CodeParsed = NanisGuardV.validation.ValidateParseStringToLong(code,nameof(Code));

            Code = CodeParsed;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Code;
        }
    }
}
