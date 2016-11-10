using System;

namespace OrderWise.Calculator.Application.Services.MathOperation
{
    public abstract class CalculatorFunction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorFunction"/> class.
        /// </summary>
        /// <param name="buttonTitle">The title.</param>
        /// <param name="buttonTooltip">The tooltip.</param>
        /// <exception cref="System.ArgumentNullException">title</exception>
        protected CalculatorFunction(object buttonTitle, object buttonTooltip)
        {
            if (string.IsNullOrEmpty(buttonTitle?.ToString()))
                throw new ArgumentNullException(nameof(buttonTitle));

            ButtonTitle = buttonTitle?.ToString();
            ButtonTooltip = buttonTooltip?.ToString();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorFunction"/> class.
        /// </summary>
        /// <param name="buttonTitle">The title.</param>
        /// <exception cref="System.ArgumentNullException">title</exception>
        protected CalculatorFunction(object buttonTitle) : this(buttonTitle, null)
        {
        }

        /// <summary>
        /// Gets or sets the button title.
        /// </summary>
        /// <value>
        /// The button title.
        /// </value>
        public string ButtonTitle { get; set; }

        /// <summary>
        /// Gets or sets the button tooltip.
        /// </summary>
        /// <value>
        /// The button tooltip.
        /// </value>
        public string ButtonTooltip { get; set; }

        /// <summary>
        /// Evaluates the result of the mathematic operation
        /// </summary>
        /// <param name="operandArgs">The operand argument(s)</param>
        /// <returns>
        /// The result of the operation
        /// </returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public abstract double Evaluate(params double[] operandArgs);
    }
}