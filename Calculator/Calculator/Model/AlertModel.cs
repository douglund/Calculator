namespace Calculator.Model
{
    public class AlertModel : ObservableObject
    {
        private string _message;
        private string _title;
        private bool _visibility = false;

        public string Title
        {
            get { return _title; }
            set
            {
                if (_title == value)
                    return;

                _title = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                if (_message == value)
                    return;

                _message = value;
                OnPropertyChanged();
            }
        }

        public bool Visibility
        {
            get { return _visibility; }
            set
            {
                if (_visibility == value)
                    return;

                _visibility = value;
                OnPropertyChanged();
            }
        }
    }
}