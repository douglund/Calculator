using System;
using System.Globalization;
using MSScriptControl;
using OrderWise.Calculator.Application.Core;

namespace OrderWise.Calculator.Application.Services
{
    public class CalculateService : ICalculateService
    {
        private const NumberStyles AllowedStyles = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
        private const string ScriptLanguage = "VBScript";

        private static readonly ScriptControl ScriptControl;

        /// <summary>
        /// Initializes the <see cref="CalculateService" /> class.
        /// </summary>
        static CalculateService()
        {
            ScriptControl = new ScriptControl
            {
                Language = ScriptLanguage
            };
        }

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

        /// <summary>
        /// Calculates a result between operands when symbol chosen.
        /// </summary>
        /// <param name="expression">math expression to evaluate.</param>
        /// <returns>
        /// Result of the last operation.
        /// </returns>
        public double Evaluate(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                expression = "0";
            double result = ScriptControl.Eval(expression);
            return result;
        }
    }
}