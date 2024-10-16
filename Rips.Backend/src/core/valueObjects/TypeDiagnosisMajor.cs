using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class TypeDiagnosisMajor : ValueObject
    {
        public TypeDiagnosisMajor(string value)
        {
            NanisGuardV.validation.NotNullOrEmpty(value);
            int valueParsed = NanisGuardV.validation.ValidateParseStringToInt(value);
            NanisGuardV.validation.NumberRange(valueParsed,1,3);
            Value = valueParsed;
        }

        public int Value { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
