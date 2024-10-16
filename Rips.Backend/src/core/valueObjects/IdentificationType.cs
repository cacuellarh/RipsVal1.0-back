using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class IdentificationType : ValueObject
    {
        public IdentificationType(string value)
        {
            NanisGuardV.validation.NotNullOrEmpty(value);
            NanisGuardV.validation.StringRequiredLength(value, 2);
            Value = value;
        }

        public string Value { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
