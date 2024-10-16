using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class Diagnosis : ValueObject
    {
        public Diagnosis(string value)
        {
            NanisGuardV.validation.NotNullOrEmpty(value);
            NanisGuardV.validation.StringRequiredLength(value,4);
            Value = value;
        }

        public string Value { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
