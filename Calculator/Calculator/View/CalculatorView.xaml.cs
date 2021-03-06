﻿using Calculator.ViewModel;
using Xamarin.Forms;

namespace Calculator.View
{
    public partial class CalculatorView : ContentPage
    {
        public CalculatorView()
        {
            InitializeComponent();
            ViewModel = new CalculatorViewModel();
        }
        
        public CalculatorViewModel ViewModel
        {
            get { return BindingContext as CalculatorViewModel; }
            set { BindingContext = value; }
        }
    }
}
