using System;

namespace OrderWise.Calculator.Application.Services.MathOperation.MathOperations
{
    public class ParenthesesOperation : MathOperation
    {
        public ParenthesesOperation() : base(Operator.Parentheses)
        {
        }

        internal override double PerformOperation(double operandLhs, double operandRhs)
        {
            throw new NotImplementedException();
        }
    }
}