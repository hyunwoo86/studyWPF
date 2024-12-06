using System.Windows.Input;
using WpfDINavigation.Commands;
using WpfDINavigation.Services;

namespace WpfDINavigation.ViewModels
{
    public class TestViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public ICommand ToLoginCommand { get; set; }
        public ICommand ToSignCommand { get; set; }

        public TestViewModel(INavigationService navigationService)
        {
            ToLoginCommand = new RelayCommand<object>(ToLogin);
            ToSignCommand = new RelayCommand<object>(ToSign);
            _navigationService = navigationService;
        }

        private void ToLogin(object _)
        {
            _navigationService.Navigate(NaviType.LoginView);
        }

        private void ToSign(object _)
        {
            _navigationService.Navigate(NaviType.SignView);
        }
    }
}
