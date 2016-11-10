using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.View;
using Xamarin.Forms;

namespace Calculator
{
    public class App : Application
    {
        public App()
        {
            var calc = new CalculatorView();
            MainPage = calc; // new NavigationPage(calc);
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
