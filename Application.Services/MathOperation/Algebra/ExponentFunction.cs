namespace OrderWise.Calculator.Application.Services.MathOperation.Algebra
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MathOperation" />
    public class ExponentFunction : CalculatorFunction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExponentFunction"/> class.
        /// </summary>
        public ExponentFunction() : base((char) 158, Operator.Exponent)
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
            return Operator.Exponent.Evaluate(operandArgs);
        }
    }
}