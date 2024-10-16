namespace Rips.Backend.src.core.interfaces
{
    public interface IFileRipFactory
    {
        public IFileRip CreateFileRip<T>(IFileRip type) where T : IFileRip;
    }
}
