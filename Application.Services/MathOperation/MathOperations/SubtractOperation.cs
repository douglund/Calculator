namespace OrderWise.Calculator.Application.Services.MathOperation.MathOperations
{
    public class SubtractOperation : MathOperation
    {
        public SubtractOperation() : base(Operator.Subtract)
        {
        }

        internal override double PerformOperation(double operandLhs, double operandRhs)
        {
            return operandLhs - operandRhs;
        }
    }
}