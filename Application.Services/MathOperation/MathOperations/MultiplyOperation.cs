namespace OrderWise.Calculator.Application.Services.MathOperation.MathOperations
{
    public class MultiplyOperation : MathOperation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiplyOperation"/> class.
        /// </summary>
        public MultiplyOperation() : base(Operator.Multiply)
        {
        }

        internal override double PerformOperation(double operandLhs, double operandRhs)
        {
            return operandLhs * operandRhs;
        }
    }
}