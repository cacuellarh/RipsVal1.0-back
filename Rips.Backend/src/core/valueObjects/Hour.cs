using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class Hour : ValueObject
    {
        public Hour(string value)
        {
            NanisGuardV.validation.NotNullOrEmpty(value);   
            TimeSpan hourParsed = NanisGuardV.validation.ValidateTryParseStringToTimeSpan(value);
            Value = hourParsed;
        }

        public TimeSpan Value { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
