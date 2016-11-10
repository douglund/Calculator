using OrderWise.Calculator.Presentation.CommonXaml.View;
using Xamarin.Forms;

namespace OrderWise.Calculator.Presentation.CommonXaml
{
	public class App : Xamarin.Forms.Application
    {
		public App ()
        {
            MainPage = new NavigationPage(new CalculatorPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}
