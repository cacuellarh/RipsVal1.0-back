using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class ShapeRealizationActSurgical : BaseValideCodeIntValueObject
    {
        public ShapeRealizationActSurgical(string value)
            : base(value, 1, 5) { }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
