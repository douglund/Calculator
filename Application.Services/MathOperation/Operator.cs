namespace OrderWise.Calculator.Application.Services.MathOperation
{
    /// <summary>
    /// Enumeration listing the mathematical operators in order of operation sequence.
    /// </summary>
    /// <remarks>
    /// In mathematics, the order of operations (or operator precedence) is a collection of rules that define 
    /// which procedures to perform first in order to evaluate a given mathematical expression.
    /// https://en.wikipedia.org/wiki/Order_of_operations
    /// </remarks>
    public enum Operator
    {
        Parentheses,
        Exponent,
        Multiply,
        Divide,
        Add,
        Subtract,
    }
}