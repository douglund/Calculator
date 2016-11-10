using System;
using System.Globalization;
using MSScriptControl;

namespace OrderWise.Calculator.Presentation.Windows.Wpf
{
    internal class EvalService : ICalculateService
    {
        private const NumberStyles AllowedStyles = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;

        /// <summary>
        /// Parses the string input as double.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public double ParseInput(string input)
        {
            var parseValue = 0d;

            if (string.IsNullOrWhiteSpace(input))
                return parseValue;

            // if (!double.TryParse(inputString, NumberStyles.Any, null, out inputValue))
            if (!double.TryParse(input, AllowedStyles, CultureInfo.CurrentUICulture, out parseValue))
                throw new ArgumentException();

            return parseValue;
        }

        public double CalculateResult(double actualValue, char operationSymbol, string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                inputString = "0";

            var sc = new ScriptControl
            {
                Language = "VBScript"
            };
            double result = sc.Eval(inputString);
            return result;
        }
    }
}