using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;
using WelcomeScreen.Utils;
using WelcomeScreen.ViewModels;
using WelcomeScreen.Views;

namespace WelcomeScreen.Commands
{
    [UsedImplicitly]
    [Transaction(TransactionMode.Manual)]
    public class Command : ExternalCommand
    {
        public override void Execute()
        {
            if (WindowController.Focus<WelcomeScreenView>()) return;

            var viewModel = new WelcomeScreenViewModel();
            var view = new WelcomeScreenView(viewModel);
            WindowController.Show(view, UiApplication.MainWindowHandle);
        }
    }
}