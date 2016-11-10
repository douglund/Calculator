using System;

namespace OrderWise.Calculator.Application.Services.MathOperation.Basic
{
    public class MultiplyFunction : CalculatorFunction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiplyFunction"/> class.
        /// </summary>
        public MultiplyFunction() : base((char) 158, Operator.Multiply)
        {
        }

        public override double Evaluate(params double[] operandArgs)
        {
            throw new NotImplementedException();
        }
    }
}