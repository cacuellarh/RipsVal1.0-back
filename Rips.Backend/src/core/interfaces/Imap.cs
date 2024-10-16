namespace Rips.Backend.src.core.interfaces
{
    public interface Imap<TOutput> where TOutput : IFileRip
    {
        public TOutput Map(string[] input);
    }
}
