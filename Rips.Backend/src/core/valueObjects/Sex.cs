using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class Sex : ValueObject
    {
        public Sex(string value)
        {
            NanisGuardV.validation.NotNull(value);
            NanisGuardV.validation.StringRequiredLength(value, 1);
            Value = value;
        }

        public string Value { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
