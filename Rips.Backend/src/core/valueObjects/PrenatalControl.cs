using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class PrenatalControl : BaseValideCodeIntValueObject
    {
        public PrenatalControl(string value) : base(value, 1, 2)
        {
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
