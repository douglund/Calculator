using System;
using System.Linq;

namespace OrderWise.Calculator.Application.Services.MathOperation.Algebra
{
    public class SquareRootFunction : CalculatorFunction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SquareRootFunction"/> class.
        /// </summary>
        public SquareRootFunction() : base("²√", "Square Root")
        {
        }

        /// <summary>
        /// Evaluates the result of the mathematic operation
        /// </summary>
        /// <param name="operandArgs">The operand argument(s)</param>
        /// <returns>
        /// The result of the operation
        /// </returns>
        public override double Evaluate(params double[] operandArgs)
        {
            if (operandArgs.Length != 1)
                throw new InvalidOperationException("Only 1 operand expected for squared function");

            var newArgs = new[]
            {
                operandArgs.Single(),
                1.0 / 2.0
            };
            return Operator.Exponent.Evaluate(newArgs);
        }
    }
}