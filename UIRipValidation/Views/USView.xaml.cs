using Microsoft.Extensions.DependencyInjection;
using Presentation.RipsValidator.Contracts;
using Presentation.RipsValidator.ViewModel;
using System.Windows.Controls;


namespace Presentation.RipsValidator.Views
{

    public partial class USView : Page
    {
        private readonly USViewModel _viewModel;
        public USView(USViewModel viewModel)
        {
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}
