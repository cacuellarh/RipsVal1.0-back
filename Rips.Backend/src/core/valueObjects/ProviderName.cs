using NanisGuard;
using NanisGuard.src;
using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class ProviderName : ValueObject
    {
        public string Value { get; private set; }
        public ProviderName(string providerName) 
        {
            NanisGuardV.validation.NotNullOrEmpty(providerName);
            NanisGuardV.validation.StringOnlyContainsLetters(providerName);
            Value = providerName;
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
