using System.Windows;
using Microsoft.Practices.Unity;
using Calculator.ViewModel;

namespace Calculator.WindowsWPF
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