using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Documents;
using System.Windows.Media;

namespace WpfApp1
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Inline> _bindableInlineList;

        public ObservableCollection<Inline> BindableInlineList
        {
            get { return _bindableInlineList; }
            set
            {
                if (_bindableInlineList != value)
                {
                    _bindableInlineList = value;
                    OnPropertyChanged(nameof(BindableInlineList));
                }
            }
        }

        public ViewModel()
        {
            BindableInlineList = new ObservableCollection<Inline>
            {
                new Run("Hello ") { Foreground = Brushes.Black },
                new Run("World!") { Foreground = Brushes.Red, FontSize = 22, }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
