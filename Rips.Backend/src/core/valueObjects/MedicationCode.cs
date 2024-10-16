using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class MedicationCode : ValueObject
    {
        public MedicationCode(string value)
        {
            NanisGuardV.validation.NotNullOrEmpty(value);
            Value = value;
        }

        public string Value { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
