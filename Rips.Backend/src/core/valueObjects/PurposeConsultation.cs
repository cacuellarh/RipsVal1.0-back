using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class PurposeConsultation : ValueObject
    {
        public PurposeConsultation(string value)
        {
            NanisGuardV.validation.NotNullOrEmpty(value);
            int purposeConsultationparsedToInt = NanisGuardV.validation.ValidateParseStringToInt(value);
            NanisGuardV.validation.NumberRange(purposeConsultationparsedToInt, 1, 9);
            Value = purposeConsultationparsedToInt;
        }

        public int Value { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
