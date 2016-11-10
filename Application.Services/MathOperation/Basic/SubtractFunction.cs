namespace OrderWise.Calculator.Application.Services.MathOperation.Basic
{
    public class SubtractFunction : CalculatorFunction
    {
        public SubtractFunction() : base((char) 45, Operator.Subtract)
        {
        }

        public override double Evaluate(params double[] operandArgs)
        {
            return Operator.Subtract.Evaluate(operandArgs);
        }
    }
}