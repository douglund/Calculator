namespace OrderWise.Calculator.Application.Services.MathOperation.MathOperations
{
    public class AddOperation : MathOperation
    {
        public AddOperation() : base(Operator.Add)
        {
        }

        internal override double PerformOperation(double operandLhs, double operandRhs)
        {
            return operandLhs + operandRhs;
        }
    }
}