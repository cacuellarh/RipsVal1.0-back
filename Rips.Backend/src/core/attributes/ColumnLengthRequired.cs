namespace Rips.Backend.src.core.attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ColumnLengthRequired : Attribute
    {
        public ColumnLengthRequired(int length)
        {
            Length = length;
        }

        public int Length { get; private set; }
    }
}
