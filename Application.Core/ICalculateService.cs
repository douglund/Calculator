namespace OrderWise.Calculator.Application.Core
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
        /// <param name="expression">math expression to evaluate.</param>
        /// <returns>Result of the last operation.</returns>
        double Evaluate(string expression);
    }
}