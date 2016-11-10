namespace OrderWise.Calculator.Application.Services.MathOperation
{
    public static class OperatorExtensions
    {
        public static double Evaluate(this Operator @operator, params double[] operandArgs)
        {
            var operation = OperationFactory.Create(@operator);
            var result = operation.Evaluate(operandArgs);
            return result;
        }
    }
}