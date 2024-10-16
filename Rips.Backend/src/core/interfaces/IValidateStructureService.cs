using Rips.Backend.src.core.dto.response;

namespace Rips.Backend.src.core.interfaces
{
    public interface IValidateStructureService
    {
        public ValidationMappingResponse ValidateFileRip(string filePath);
    }
}
