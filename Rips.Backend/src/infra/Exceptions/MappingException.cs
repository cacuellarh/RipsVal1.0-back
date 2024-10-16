namespace Rips.Backend.src.infra.Exceptions
{
    public class MappingException : Exception
    {
        public MappingException(string message) : base(message)
        {
        }

        public MappingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public MappingException() : base("An error occurred during mapping.")
        {
        }
    }
}
