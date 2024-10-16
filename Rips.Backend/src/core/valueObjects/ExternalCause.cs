using NanisGuard.src;
using NanisGuard;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class ExternalCause : ValueObject
    {
        public ExternalCause(string value)
        {
            NanisGuardV.validation.NotNullOrEmpty(value);
            int externalCause = NanisGuardV.validation.ValidateParseStringToInt(value);
            NanisGuardV.validation.NumberRange(externalCause, 1, 15);
            Value = externalCause;
        }

        public int Value { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
