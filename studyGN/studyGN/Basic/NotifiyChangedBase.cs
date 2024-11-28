using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace studyGN.Basic
{
    class NotifiyChangedBase
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
