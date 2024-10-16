using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class Weight : ValueObject
    {
        public Weight(string value)
        {
            NanisGuardV.validation.NotNullOrEmpty(value);
            int valueParsed = NanisGuardV.validation.ValidateParseStringToInt(value);
            NanisGuardV.validation.DigitNotBeNegative(valueParsed);

            Value = valueParsed;
        }

        public int Value { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
