using WelcomeScreen.ViewModels;

namespace WelcomeScreen.Views
{
    public partial class WelcomeScreenView
    {
        public WelcomeScreenView(WelcomeScreenViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}