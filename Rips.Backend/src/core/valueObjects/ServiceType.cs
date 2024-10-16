using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class ServiceType : BaseValideCodeIntValueObject
    {
        public ServiceType(string value) : base(value, 1, 4)
        {
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
