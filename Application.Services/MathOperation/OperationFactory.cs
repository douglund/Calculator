using System.Collections.Generic;
using OrderWise.Calculator.Application.Services.MathOperation.MathOperations;

namespace OrderWise.Calculator.Application.Services.MathOperation
{
    public static class OperationFactory
    {
        private static readonly Dictionary<Operator, MathOperation> OperatorRegistry = new Dictionary<Operator, MathOperation>()
        {
            {
                Operator.Parentheses, new ParenthesesOperation()
            },
            {
                Operator.Exponent, new ExponentOperation()
            },
            {
                Operator.Multiply, new MultiplyOperation()
            },
            {
                Operator.Divide, new DivideOperation()
            },
            {
                Operator.Add, new AddOperation()
            },
            {
                Operator.Subtract, new SubtractOperation()
            }
        };

        public static MathOperation Create(Operator @operator)
        {
            return OperatorRegistry[@operator];
        }
    }
}