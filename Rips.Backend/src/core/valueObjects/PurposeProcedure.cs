using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class PurposeProcedure : BaseValideCodeIntValueObject
    {
        public PurposeProcedure(string value) : base(value,1,5)
        {

        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
