using Rips.Backend.src.core.interfaces;

namespace Rips.Backend.src.core.dto.response
{
    public class ValidationMappingResponse
    {
        public ValidationMappingResponse(ICollection<IFileRip> records, List<string> errors)
        {
            Records = records;
            Errors = errors;
        }

        public ICollection<IFileRip> Records { get; private set; }
        public List<string> Errors { get; private set; }
    }
}
