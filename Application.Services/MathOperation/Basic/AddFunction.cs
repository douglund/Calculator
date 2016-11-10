namespace OrderWise.Calculator.Application.Services.MathOperation.Basic
{
    public class AddFunction : CalculatorFunction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddFunction"/> class.
        /// </summary>
        public AddFunction() : base((char) 43, Operator.Add)
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
            return Operator.Add.Evaluate(operandArgs);
        }
    }
}