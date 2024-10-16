

using Presentation.RipsValidator.Core.Types;
using System.ComponentModel;
using System.Xml;

namespace Presentation.RipsValidator.Services
{
    public class FileService :IFileService
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public FileService() { }

        private ValidationFileType _validationType;
        public ValidationFileType ValidationTypeSelected
        {
            get => _validationType;
            set
            {
                if (_validationType != value)
                {
                    _validationType = value;
                    OnPropertyChanged(nameof(ValidationTypeSelected));
                }
            }
        }
        private string _filePath = string.Empty;
        public string FilePath
        {
            get => _filePath;
            set
            {
                if (_filePath != value)
                {
                    _filePath = value;
                    OnPropertyChanged(nameof(FilePath)); // Notifica a los suscriptores
                }
            }
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
