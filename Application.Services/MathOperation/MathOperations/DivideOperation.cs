namespace OrderWise.Calculator.Application.Services.MathOperation.MathOperations
{
    public class DivideOperation : MathOperation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DivideOperation"/> class.
        /// </summary>
        public DivideOperation() : base(Operator.Divide)
        {
        }

        internal override double PerformOperation(double operandLhs, double operandRhs)
        {
            return operandLhs / operandRhs;
        }
    }
}