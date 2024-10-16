using NanisGuard;
using NanisGuard.src;

namespace Rips.Backend.src.core.commons
{
    public abstract class BaseValideCodeIntValueObject : ValueObject
    {
        protected BaseValideCodeIntValueObject(
            string value,
            int minValue,
            int maxValue)
        {
            NanisGuardV.validation.NotNullOrEmpty(value);
            var valueParsed = NanisGuardV.validation.ValidateParseStringToInt(value);
            NanisGuardV.validation.NumberRange(valueParsed, minValue, maxValue);
            Value = valueParsed;
        }

        public int Value { get; private set; }
    }
}
