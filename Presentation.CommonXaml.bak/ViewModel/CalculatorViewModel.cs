// ReSharper disable ExplicitCallerInfoArgument

using OrderWise.Calculator.Presentation.CommonXaml.Model;

namespace OrderWise.Calculator.Presentation.CommonXaml.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ObservableObject" />
    /// <seealso cref="ObservableObject" />
    public class CalculatorViewModel : ObservableObject
    {
        private const char EqualSymbol = '=';
        private string _historyString;
        private string _inputString;
        private char _previousSymbol;
        private double _previousValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorViewModel"/> class.
        /// </summary>
        public CalculatorViewModel()
        {
            ChooseDigitCommand = new Command<string>(OnDigitChosen());
            ChooseSymbolCommand = new Command<string>(OnSymbolChosen());
            ChooseEqualCommand = new Command<string>(OnEqualsChosen());
            ChooseClearCommand = new Command(OnClearChosen());
            ChooseClearEntryCommand = new Command(OnClearEntryChosen());
            ChooseBackspaceCommand = new Command(OnBackspaceChosen());
            ChooseMemoryPlusCommand = new Command(OnMemoryPlusChosen());
            ChooseMemoryRecallCommand = new Command(OnMemoryRecallChosen());
            OnClearChosen();
        }

        /// <summary>
        /// Gets or sets the calculate service.
        /// </summary>
        /// <value>
        /// The calculate service.
        /// </value>
        [Microsoft.Practices.Unity.Dependency]
        public ICalculateService CalculateService { get; set; }

        public ICommand ChooseDigitCommand { get; }
        public ICommand ChooseSymbolCommand { get; }
        public ICommand ChooseEqualCommand { get; }
        public ICommand ChooseClearCommand { get; }
        public ICommand ChooseClearEntryCommand { get; }
        public ICommand ChooseBackspaceCommand { get; }
        public ICommand ChooseMemoryPlusCommand { get; }
        public ICommand ChooseMemoryRecallCommand { get; }

        public AlertModel Alert { get; set; } = new AlertModel();

        public double MemoryValue { get; set; }

        public string InputText => string.IsNullOrWhiteSpace(InputString) && string.IsNullOrWhiteSpace(HistoryString)
            ? "0"
            : InputString;

        public string InputString
        {
            get { return _inputString; }
            set
            {
                if (_inputString == value)
                    return;

                _inputString = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(InputText));
            }
        }

        public string HistoryString
        {
            get { return _historyString; }
            set
            {
                if (_historyString == value)
                    return;

                _historyString = value;
                OnPropertyChanged();
            }
        }

        public double PreviousValue
        {
            get { return _previousValue; }
            set
            {
                if (_previousValue.Equals(value))
                    return;

                _previousValue = value;
                OnPropertyChanged();
            }
        }

        public char PreviousSymbol
        {
            get { return _previousSymbol; }
            set
            {
                if (_previousSymbol == value)
                    return;

                _previousSymbol = value;
                OnPropertyChanged();
            }
        }

        private Action<string> OnDigitChosen()
        {
            return key =>
            {
                ClearAlert();
                if (PreviousSymbol == EqualSymbol)
                    InputString = string.Empty;
                InputString += key;
                HistoryString += key;
            };
        }

        private Action<string> OnSymbolChosen()
        {
            return key =>
            {
                CalculateResult(key);
                InputString = string.Empty;
                HistoryString += $"{key}";
            };
        }

        private Action<string> OnEqualsChosen()
        {
            return key =>
            {
                CalculateResult(key);
                InputString = PreviousValue.ToString(CultureInfo.InvariantCulture);
                HistoryString = InputString;
                PreviousSymbol = char.MaxValue;
            };
        }

        private Action OnClearEntryChosen()
        {
            return () =>
            {
                ClearAlert();
                if (string.IsNullOrEmpty(InputString))
                    return;

                HistoryString = HistoryString.Substring(0, HistoryString.Length - InputString.Length);
                InputString = string.Empty;
            };
        }

        private Action OnClearChosen()
        {
            return () =>
            {
                ClearAlert();
                HistoryString = string.Empty;
                InputString = string.Empty;
                PreviousValue = 0;
                PreviousSymbol = char.MinValue;
                MemoryValue = 0;
            };
        }

        private Action OnMemoryPlusChosen()
        {
            return () =>
            {
                ClearAlert();
                MemoryValue += CalculateService.ParseInput(InputString);
            };
        }

        private Action OnMemoryRecallChosen()
        {
            return () =>
            {
                ClearAlert();
                OnClearEntryChosen().Invoke();
                OnDigitChosen().Invoke(MemoryValue.ToString(CultureInfo.InvariantCulture));
            };
        }

        private Action OnBackspaceChosen()
        {
            return () =>
            {
                ClearAlert();
                if (!string.IsNullOrEmpty(InputString))
                    InputString = InputString.Substring(0, InputString.Length - 1);
                if (!string.IsNullOrEmpty(HistoryString))
                    HistoryString = HistoryString.Substring(0, HistoryString.Length - 1);
            };
        }

        private void CalculateResult(string key)
        {
            try
            {
                ClearAlert();
                PreviousValue = CalculateService.Evaluate(HistoryString);
            }
            catch (DivideByZeroException)
            {
                SetAlert("Division by Zero is not allowed", "Division by Zero");
            }
            catch (OverflowException)
            {
                SetAlert("The number is too large");
            }
            catch (ArgumentException)
            {
                SetAlert("Invalid number input");
            }
            catch (Exception ex)
            {
                SetAlert(ex.Message, ex.GetType().Name);
            }
            PreviousSymbol = key[0];
        }

        private void ClearAlert()
        {
            SetAlert(string.Empty, string.Empty);
        }

        private void SetAlert(string message, string title = "Error")
        {
            Alert.Message = message;
            Alert.Title = title;
            Alert.Visibility = string.IsNullOrEmpty(message)
                ? Visibility.Collapsed
                : Visibility.Visible;
        }
    }
}