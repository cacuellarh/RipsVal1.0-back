using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;
using Rips.Backend.src.core.extensions;

namespace Rips.Backend.src.core.valueObjects
{
    public class AutorizationNumber : ValueObject
    {
        public AutorizationNumber(string value)
        {
            NanisGuardV.validation.AutorizationNumberWarning(value);
            var autorizationNumberParsedLong = NanisGuardV.validation.ValidateParseStringToLong(value);
            Value = autorizationNumberParsedLong;
        }

        public long Value { get; private set; } 
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
