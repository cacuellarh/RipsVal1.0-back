using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class Age : ValueObject
    {
        public Age(string value)
        {
            NanisGuardV.validation.NotNull(value);
            var ageParse = NanisGuardV.validation.ValidateParseStringToInt(value);
            NanisGuardV.validation.NumberRange(ageParse, 1, 120);
            Value = ageParse;
        }

        public int Value { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
