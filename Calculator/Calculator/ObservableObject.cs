using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator
{
    /// <summary>
    /// Implements interface <see cref="INotifyPropertyChanged" /> event and its subscriber.
    /// </summary>
    public abstract class ObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Is called when ViewModel property was changed. 
        /// </summary>
        /// <param name="propertyName">The name of property was changed.</param>
        internal void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}