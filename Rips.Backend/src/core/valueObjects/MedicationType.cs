using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class MedicationType : BaseValideCodeIntValueObject
    {
        public MedicationType(string value) : base(value, 1, 2)
        {
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
