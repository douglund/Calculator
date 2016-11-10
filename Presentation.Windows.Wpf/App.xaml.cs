using System;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Practices.Unity;
using OrderWise.Calculator.Presentation.WinApp.Wpf.Bootstrap;

namespace OrderWise.Calculator.Presentation.WinApp.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var container = IocContainer.Current;
            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();
        }

        private void OnLoadCompleted(object sender, NavigationEventArgs navigationEventArgs)
        {


        }
    }
}