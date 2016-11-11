using System.Windows;
using System.Windows.Navigation;
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
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void OnLoadCompleted(object sender, NavigationEventArgs navigationEventArgs)
        {


        }
    }
}