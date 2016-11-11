using System;
using System.Globalization;

namespace Calculator.Services
{
    public class CalculateService : ICalculateService
    {
        private const char PlusSymbol = '+';
        private const char MinusSymbol = '-';
        private const char MultiplySymbol = '*';
        private const char DivideSymbol = '/';

        private const char DecimalDigit = '.';
        private const char ZeroDigit = '0';

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
            if (!double.TryParse(input, AllowedStyles, CultureInfo.InvariantCulture, out parseValue))
                throw new ArgumentException();

            return parseValue;
        }

        /// <summary>
        /// Calculates the result between operations when symbol chosen.
        /// </summary>
        /// <param name="actualValue">Value was actual before symbol button was pressed.</param>
        /// <param name="operationSymbol">Symbol to make operation.</param>
        /// <param name="inputString">New entered string as number to work with.</param>
        /// <returns>Result of the last operation.</returns>
        public double Evaluate(double actualValue, char operationSymbol, string inputString)
        {
            var inputValue = ParseInput(inputString);
            if (operationSymbol == DecimalDigit)
                actualValue += ZeroDigit;
            switch (operationSymbol)
            {
                case PlusSymbol:
                    actualValue += inputValue;
                    break;
                case MinusSymbol:
                    actualValue -= inputValue;
                    break;
                case MultiplySymbol:
                    actualValue *= inputValue;
                    break;
                case DivideSymbol:
                    if (inputValue.Equals(0d))
                        throw new DivideByZeroException();

                    actualValue /= inputValue;
                    break;
                default:
                    actualValue = inputValue;
                    break;
            }

            return actualValue;
        }
    }
}