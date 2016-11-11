namespace Calculator.Services
{
    /// <summary>
    /// Calculates a result by symbol choice.
    /// </summary>
    public interface ICalculateService
    {
        /// <summary>
        /// Parses the string input as double.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns></returns>
        double ParseInput(string input);

        /// <summary>
        /// Calculates a result between operands when symbol chosen.
        /// </summary>
        /// <param name="actualValue">The actual value.</param>
        /// <param name="operationSymbol">The operation symbol.</param>
        /// <param name="inputString">The input string.</param>
        /// <returns>
        /// Result of the last operation.
        /// </returns>
        double Evaluate(double actualValue, char operationSymbol, string inputString);
    }
}