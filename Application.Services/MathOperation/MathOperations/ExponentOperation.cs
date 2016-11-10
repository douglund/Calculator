using System;

namespace OrderWise.Calculator.Application.Services.MathOperation.MathOperations
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="MathOperation" />
    public class ExponentOperation : MathOperation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExponentOperation"/> class.
        /// </summary>
        public ExponentOperation() : base(Operator.Exponent)
        {
        }

        /// <summary>
        /// Performs the calculation.
        /// </summary>
        /// <param name="baseOperand">The base operand.</param>
        /// <param name="exponent">The exponent.</param>
        /// <returns></returns>
        internal override double PerformOperation(double baseOperand, double exponent)
        {
            return Math.Pow(baseOperand, exponent);
        }
    }
}