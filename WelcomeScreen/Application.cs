using Nice3point.Revit.Toolkit.External;
using WelcomeScreen.Commands;
using WelcomeScreen.Utils;
using WelcomeScreen.ViewModels;
using WelcomeScreen.Views;

namespace WelcomeScreen
{
    [UsedImplicitly]
    public class Application : ExternalApplication
    {
        public override void OnStartup()
        {
            OnstartScreen();
            CreateRibbon();
        }

        private void CreateRibbon()
        {
            var panel = Application.CreatePanel("Panel name", "WelcomeScreen");

            var showButton = panel.AddPushButton<Command>("Button text");
            showButton.SetImage("/WelcomeScreen;component/Resources/Icons/RibbonIcon16.png");
            showButton.SetLargeImage("/WelcomeScreen;component/Resources/Icons/RibbonIcon32.png");
        }

        private void OnstartScreen()
        {
            if (WindowController.Focus<WelcomeScreenView>()) return;

            var viewModel = new WelcomeScreenViewModel();
            var view = new WelcomeScreenView(viewModel);
            WindowController.Show(view, UiApplication.MainWindowHandle);
        }
    }
}