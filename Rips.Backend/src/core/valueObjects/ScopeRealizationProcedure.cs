using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class ScopeRealizationProcedure : BaseValideCodeIntValueObject
    {
        public ScopeRealizationProcedure(string value) : base (value,1,3)
        {

        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
