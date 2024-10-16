using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class PriceValue : ValueObject
    {
        public PriceValue(string value)
        {
            NanisGuardV.validation.NotNullOrEmpty(value);
            var priceParse = NanisGuardV.validation.ValidateParseStringToInt(value);
            NanisGuardV.validation.DigitNotBeNegative(priceParse);

            Value = priceParse;
        }

        public int Value { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
