
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace KabulTalk.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public ICommand ToChangePwdCommand { get; }
        public ICommand ToLoginCommand { get; }
        public ICommand ToSignupCommand { get; }

        public MainViewModel()
        {
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(LoginControlViewModel));

            ToChangePwdCommand = new RelayCommand(ToChangePwd);
            ToLoginCommand = new RelayCommand(ToLogin);
            ToSignupCommand = new RelayCommand(ToSignup);
        }

        private void ToLogin()
        {
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(LoginControlViewModel));
        }

        private void ToChangePwd()
        {
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(ChangePwdControlViewModel));
        }

        private void ToSignup()
        {
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(SignupControlViewModel));
        }

        private INotifyPropertyChanged _currentViewModel;
        public INotifyPropertyChanged CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }
    }
}


