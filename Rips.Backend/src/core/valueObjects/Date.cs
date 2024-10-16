using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class Date : ValueObject
    {
        public DateTime Value { get; set; }
        public Date(string date) 
        { 
            var dateParse = NanisGuardV.validation.ValidateParseStringToDate(date,nameof(Value));

            Value = dateParse;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
