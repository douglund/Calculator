namespace OrderWise.Calculator.Application.Services.MathOperation.Basic
{
    public class DivideFunction : CalculatorFunction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DivideFunction"/> class.
        /// </summary>
        public DivideFunction() : base((char) 246, Operator.Divide)
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
            return Operator.Divide.Evaluate(operandArgs);
        }
    }
}