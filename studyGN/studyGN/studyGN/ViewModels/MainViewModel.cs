using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace studyGN.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string text1;
        private string text2;
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainViewModel()
        {

        }

        public string Text1
        {
            get { return text1; }
            set { text1 = value; OnPropertyChanged(); }
        }


        public string Text2
        {
            get { return text2; }
            set { text2 = value; OnPropertyChanged(); }
        }

        public ICommand ClearCommand => new ClearCommand(this);
    }
}
