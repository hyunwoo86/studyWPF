using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDINavigation.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private INotifyPropertyChanged _currentViewModel;

        public MainViewModel()
        {
            CurrentViewModel = new LoginViewModel();
        }


        public INotifyPropertyChanged CurrentViewModel
        {
            get { return _currentViewModel; }
            set { _currentViewModel = value; OnPropertyChanged(); }
        }

    }
}
