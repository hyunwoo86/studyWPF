using WpfDINavigation.Commands;
using System.Windows.Input;
using WpfDINavigation.Services;
using WpfDINavigation.Stores;

namespace WpfDINavigation.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly SignupStore _signupStore;
        private string _id;
        private string _password;

        public ICommand ToSignupCommand { get; set; }
        public ICommand ToTestCommand { get; set; }

        public LoginViewModel(INavigationService navigationService, SignupStore signupStore)
        {
            ToSignupCommand = new RelayCommand<object>(ToSignup);
            ToTestCommand = new RelayCommand<object>(ToTest);
            _navigationService = navigationService;
            _signupStore = signupStore;
        }

        private void ToSignup(object _)
        {
            _signupStore.CurrentAccount = new Models.Account { Id = Id, Password = Password };
            _navigationService.Navigate(NaviType.SignView);
        }

        private void ToTest(object _)
        {
            _navigationService.Navigate(NaviType.TestView);
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(); }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }

    }
}
