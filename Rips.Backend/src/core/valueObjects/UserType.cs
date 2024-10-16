using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class UserType : ValueObject
    {
        public UserType(string value)
        {
            NanisGuardV.validation.NotNullOrEmpty(value);
            var userTypeParseToInt = NanisGuardV.validation.ValidateParseStringToInt(value);
            NanisGuardV.validation.IntRequiredLength(userTypeParseToInt, 1);
            NanisGuardV.validation.NumberRange(userTypeParseToInt, 1,8);
            Value = userTypeParseToInt;
        }

        public int Value { get; private set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
