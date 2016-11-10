using System;

namespace OrderWise.Calculator.Application.Services.MathOperation
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class MathOperation
    {
        protected MathOperation(Operator @operator, int minOperands = 2)
        {
            Operator = @operator;
            MinOperands = minOperands;
        }

        /// <summary>
        /// Gets or sets the minimum number of operands required to perform the operation.
        /// </summary>
        /// <value>
        /// The minimum operands.
        /// </value>
        public int MinOperands { get; protected set; }

        /// <summary>
        /// Gets or sets the order of operation.
        /// </summary>
        /// <value>
        /// The order of operation.
        /// </value>
        /// <remarks>
        /// In mathematics, the order of operations (or operator precedence) is a collection of rules that define 
        /// which procedures to perform first in order to evaluate a given mathematical expression.
        /// https://en.wikipedia.org/wiki/Order_of_operations
        /// </remarks>
        public Operator Operator { get; protected set; }

        /// <summary>
        /// Evaluates the result of the mathematic operation
        /// </summary>
        /// <param name="operandArgs">In mathematics, an operand is the object of a mathematical operation, a quantity on which an operation is performed.</param>
        /// <returns>The result of the operation</returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public double Evaluate(params double[] operandArgs)
        {
            // Validate operands
            if (operandArgs.Length < MinOperands)
                throw new InvalidOperationException($"At least {MinOperands} digits required for {GetType().Name} operation");

            // Evaluate result 
            var result = operandArgs[0];
            for (var i = 1; i < operandArgs.Length; i++)
                result = PerformOperation(operandArgs[i - 1], operandArgs[i]);

            return result;
        }

        /// <summary>
        /// Performs the calculation.
        /// </summary>
        /// <param name="operandLhs">The digit LHS.</param>
        /// <param name="operandRhs">The digit RHS.</param>
        /// <returns></returns>
        internal abstract double PerformOperation(double operandLhs, double operandRhs);
    }
}