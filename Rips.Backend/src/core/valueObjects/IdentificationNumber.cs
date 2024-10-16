using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class IdentificationNumber : ValueObject
    {
        public IdentificationNumber(string value)
        {
            NanisGuardV.validation.NotNull(value);
            NanisGuardV.validation.StringMaxLength(value, 16);
            long numberParse = NanisGuardV.validation.ValidateParseStringToLong(value);

            Value = numberParse;
        }

        public long Value { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
