using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class StateToExit : BaseValideCodeIntValueObject
    {
        public StateToExit(string value) : base(value, 1, 2)
        {
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
