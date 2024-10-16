using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class UnitOfMeasurement : ValueObject
    {
        public UnitOfMeasurement(string value)
        {
            NanisGuardV.validation.NotNullOrEmpty(value);
            var unitParsed = NanisGuardV.validation.ValidateParseStringToInt(value);
            NanisGuardV.validation.NumberRange(unitParsed,1, 3);
            Value = unitParsed;
        }

        public int Value { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
