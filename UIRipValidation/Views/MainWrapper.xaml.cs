
using Microsoft.Win32;
using Presentation.RipsValidator.Services;
using Presentation.RipsValidator.ViewModel;

using System.Windows;
using System.Windows.Controls;
using System.Xml;


namespace Presentation.RipsValidator.Views
{
    /// <summary>
    /// Lógica de interacción para MainWrapper.xaml
    /// </summary>
    public partial class MainWrapper : Page
    {
        private string pathFile { get;set; }
        private readonly IServiceProvider _serviceProvider;
        private readonly USViewModel viewModel;
        private readonly IFileService _fileService;
        public MainWrapper(USViewModel _viewModel, IFileService fileService)
        {
            InitializeComponent();
            viewModel = _viewModel;
            DataContext = _viewModel;
            _fileService = fileService;
        }

        private void NavigateToUSView_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new USView(viewModel));
        }

        private void LoadFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecciona un archivo";
            openFileDialog.Filter = "Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                pathFile = openFileDialog.FileName;

                _fileService.FilePath = pathFile;
                MessageBox.Show($"Archivo seleccionado: {pathFile}", "Archivo Seleccionado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
       
    }
}
