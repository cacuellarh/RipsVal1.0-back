using Rips.Backend.src.core.interfaces;

namespace Rips.Backend.src.core.configuration
{
    public interface IColumnLengthRequiredRegister
    {
        public int GetColumnRequiredLength<FileRip>() where FileRip : IFileRip;
    }
}