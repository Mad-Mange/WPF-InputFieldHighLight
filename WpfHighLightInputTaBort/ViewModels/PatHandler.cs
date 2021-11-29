using System.Diagnostics;






namespace WpfHighLightInputTaBort.ViewModels
{
    public class PatHandler : ObservableObject
    {
        private string _pathText;
        private bool _pathTrue;

        public string PathText
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_pathText))
                {
                    PathTrue = false;
                    Debug.Print(_pathTrue.ToString());
                    return "NoPathFound";
                }
                else
                {
                    PathTrue = true;
                    Debug.Print(_pathText);
                    Debug.Print(_pathTrue.ToString());
                    return _pathText;
                }
            }
            set
            {
                _pathText = value;
                OnPropertyChanged(nameof(PathText));
            }
        }

        public bool PathTrue
        {
            get
            {
                return _pathTrue;
            }
            set
            {
                _pathTrue = value;
                OnPropertyChanged(nameof(PathTrue));
            }
        }
    }
}
