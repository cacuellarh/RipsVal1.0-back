
using Presentation.RipsValidator.Services;
using System.Collections.ObjectModel;
using System.Windows;
using System.Xml;

namespace Presentation.RipsValidator.ViewModel
{
    public class USViewModel : ViewModelBase
    {
        public RelayCommand ValidateUSDataCommand { get;}

        private readonly IFileService _fileService;

        private ObservableCollection<string> _validationMessages;

        public RelayCommand ValidationFileSelectionCommand { get; }
        //public ValidationFileType ValidationType 
        //{
        //    get
        //    {
        //        return _validationType;
        //    }
        //    set
        //    {
        //        if (_validationType != value)
        //        {
        //            OnPropertyChanged(nameof(ValidationType));
        //        }
        //    }
        //}
        public ObservableCollection<string> ValidationMessages
        {
            get
            {
                return _validationMessages;
            }
            set
            {
                if (_validationMessages != value)
                {
                    _validationMessages = value;
                    OnPropertyChanged(nameof(ValidationMessages)); 
                }
            }
        }
        public USViewModel(IFileService fileService)
        {
            _fileService = fileService;
            ValidateUSDataCommand = new RelayCommand(ValidateStructData, FilePathNotNullOrWhiteSpace);
            //ValidationFileSelectionCommand = new RelayCommand(SelectValidationTipe);
        }

        private bool FilePathNotNullOrWhiteSpace(object obj)
        {
            return !string.IsNullOrEmpty(FilePath);
            
        }

        private void ValidateStructData(object obj)
        {

            //if (ValidationMessages == null) ValidationMessages = new ObservableCollection<string>();

            //ValidationMessages.Clear();

            //var result = _useCaseValidate.Execute(FilePath);

            //if (!result.Success)
            //{
            //    MessageBox.Show($"Se realizo validacion del archivo y se encontraron ({result.Errors.Count}) errores. Validacion tipo : {ValidationType}");
            //    AddMessageValidationObservables(result.Errors);
            //}
            //else
            //{
            //    AddMessageValidationObservables(result.ValueResult);
            //}

        }
        private void AddMessageValidationObservables(List<string> errors)
        { 
            foreach(var error in errors) 
            {
                ValidationMessages.Add(error);
            }
        }

        //private void SelectValidationTipe(object parameter)
        //{
        //    var convertedResult = ConverterPrimitives.ConverterObjToInt(parameter);
        //    if (convertedResult.Success)
        //    {
        //        _fileService.ValidationTypeSelected = (ValidationFileType)convertedResult.ValueResult;
        //    }
        //    else
        //    {
        //        MessageBox.Show("no");
        //    }

        //    MessageBox.Show($"seleccionado es {_fileService.ValidationTypeSelected} ");
        //}

        public string FilePath => _fileService.FilePath;
    }
}
