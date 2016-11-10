using System.Windows;
using Microsoft.Practices.Unity;
using OrderWise.Calculator.Presentation.CommonXaml.ViewModel;


namespace OrderWise.Calculator.Presentation.WinApp.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        [Dependency]
        public CalculatorViewModel ViewModel
        {
            get { return DataContext as CalculatorViewModel; }
            set { DataContext = value; }
        }
    }
}