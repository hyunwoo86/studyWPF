using System.Windows.Input;
using WpfDINavigation.Commands;
using WpfDINavigation.Services;

namespace WpfDINavigation.ViewModels
{
    public class SignupViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public ICommand ToLoginCommand { get; set; }
        public ICommand ToTestCommand { get; set; }

        public SignupViewModel(INavigationService navigationService)
        {
            ToLoginCommand = new RelayCommand<object>(ToLogin);
            ToTestCommand = new RelayCommand<object>(ToTest);
            _navigationService = navigationService;
        }

        private void ToLogin(object _)
        {
            _navigationService.Navigate(NaviType.LoginView);
        }

        private void ToTest(object _)
        {
            _navigationService.Navigate(NaviType.TestView);
        }
    }
}
