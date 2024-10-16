using NanisGuard.src;
using Rips.Backend.src.core.configuration;
using Rips.Backend.src.core.dto.response;
using Rips.Backend.src.core.interfaces;

namespace Rips.Backend.src.core.domainService
{
    public class ValidateStructureService<FileRip> : IValidateStructureService
        where FileRip : IFileRip
    {
        private readonly Imap<FileRip> _map;
        private readonly List<FileRip> _fileRipsRecordsMapped;
        private readonly IFileFlatReader _fileFlatReader;
        private readonly IColumnLengthRequiredRegister _columnLengthRequiredRegister;
        public ValidateStructureService(Imap<FileRip> map,
            IColumnLengthRequiredRegister columnLengthRequiredRegister,
            IFileFlatReader fileFlatReader
            )
        {
            _map = map;
            _fileRipsRecordsMapped = new List<FileRip>();
            _fileFlatReader = fileFlatReader;
            _columnLengthRequiredRegister = columnLengthRequiredRegister;
        }
        public ValidationMappingResponse ValidateFileRip(string filePath)
        {
            var errors = new List<string>();
            foreach (var row in GetDataFromFile(filePath)) 
            {
                try
                { 
                    ValidateRowLength(row);
                    var fileMapped = _map.Map(row);
                    _fileRipsRecordsMapped.Add(fileMapped);
                }
                catch (Exception ex) 
                {
                    errors.Add(ex.Message);
                }   
            }

            return CreateResponse(errors);

        }
        private ValidationMappingResponse CreateResponse(List<string> errors)
        {
            var mappedFiles = _fileRipsRecordsMapped.Select(file => (IFileRip)file).ToList();
            return new ValidationMappingResponse(mappedFiles, errors);
        }
        private void ValidateRowLength(string[] row)
            => NanisGuardV.validation.EnumerableLengthRequired(row.Count(),
                _columnLengthRequiredRegister.GetColumnRequiredLength<FileRip>());
        
        private List<string[]> GetDataFromFile(string filePath) 
            => _fileFlatReader.ReadFile(filePath);

    }
}
