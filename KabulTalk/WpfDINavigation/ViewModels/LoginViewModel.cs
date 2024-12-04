using WpfDINavigation.Commands;
using System.Windows.Input;
using WpfDINavigation.Services;

namespace WpfDINavigation.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public ICommand ToSignupCommand { get; set; }
        public ICommand ToTestCommand { get; set; }

        public LoginViewModel(INavigationService navigationService)
        {
            ToSignupCommand = new RelayCommand<object>(ToSignup);
            ToTestCommand = new RelayCommand<object>(ToTest);
            _navigationService = navigationService;
        }

        private void ToSignup(object _)
        {
            _navigationService.Navigate(NaviType.SignView);
        }

        private void ToTest(object _)
        {
            _navigationService.Navigate(NaviType.TestView);
        }
    }
}
