using System.Windows;
using System.Windows.Navigation;
using Calculator.Shared.Bootstrap;
using Microsoft.Practices.Unity;

namespace Calculator.WindowsWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var container = Container.Current;
            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }

        private void OnLoadCompleted(object sender, NavigationEventArgs navigationEventArgs)
        {


        }
    }
}