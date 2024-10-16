
using System.Windows;
using System.Windows.Input;

namespace Presentation.RipsValidator.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        private string _password;
        private string _errorMessage;
        private bool _isVisible;

        public string Username 
        {
            get
            { 
                return _username;
            }
            set
            { 
                _username = value;
                OnPropertyChanged(nameof(Username));
                LogingCommand.RaiseCanExecuteChanged();
            }
        }
        public string Password 
        {
            get
            { 
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
                LogingCommand.RaiseCanExecuteChanged();
            }
        }
        public string ErrorMessage 
        {
            get
            { 
                return _errorMessage;
            }

            set
            { 
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
                CommandManager.InvalidateRequerySuggested();
            }
        }
        public bool IsVisible 
        {
            get
            { 
                return _isVisible;
            }

            set
            {
                _isVisible = value;
                OnPropertyChanged(nameof(IsVisible));
                CommandManager.InvalidateRequerySuggested();
            } 
        }
        public RelayCommand LogingCommand { get;}

        public LoginViewModel()
        {
            LogingCommand = new RelayCommand(loginCommandHandler, CanExecuteLoginCommand);
        }

        private void loginCommandHandler(object obj)
        {
            MessageBox.Show("inicio de sesion exitoso.");
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData = !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);

            if (!validData)
            {
                IsVisible = true;
                ErrorMessage = "Error al logear. Asegúrese de que el nombre de usuario tenga al menos 3 caracteres y que la contraseña no esté vacía.";
            }
            else
            {
                IsVisible = false;
                ErrorMessage = string.Empty;
            }

            return validData;
        }
    }
}
