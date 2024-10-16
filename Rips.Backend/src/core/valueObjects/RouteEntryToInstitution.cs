using Rips.Backend.src.core.commons;

namespace Rips.Backend.src.core.valueObjects
{
    public class RouteEntryToInstitution : BaseValideCodeIntValueObject
    {
        public RouteEntryToInstitution(string value) : base(value, 1, 4)
        {
        }
        public int Value { get; private set; }  
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
