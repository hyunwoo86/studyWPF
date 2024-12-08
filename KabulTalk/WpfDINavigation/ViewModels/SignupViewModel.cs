using System.Windows.Input;
using WpfDINavigation.Commands;
using WpfDINavigation.Models;
using WpfDINavigation.Services;
using WpfDINavigation.Stores;

namespace WpfDINavigation.ViewModels
{
    public class SignupViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly LeftStore _leftStore;

        private Account CurrentAccount => _signupStore.CurrentAccount;
        public ICommand ToLoginCommand { get; set; }
        public ICommand ToTestCommand { get; set; }
        public SignupStore _signupStore { get; }
        private string _id = "";
        private string _password = "";
        private string _name = "";
        private string _email = "";

        public SignupViewModel(INavigationService navigationService, SignupStore signupStore, LeftStore leftStore)
        {
            ToLoginCommand = new RelayCommand<object>(ToLogin);
            ToTestCommand = new RelayCommand<object>(ToTest);
            _navigationService = navigationService;
            _signupStore = signupStore;
            _leftStore = leftStore;
            Initialize();
        }

        private void Initialize()
        {
            Id = CurrentAccount.Id;

            Password = CurrentAccount.Password;
        }

        private void ToLogin(object _)
        {
            _navigationService.Navigate(NaviType.LoginView);
        }

        private void ToTest(object _)
        {
            _leftStore.CurrentAccount = new Account()
            {
                Id = Id,
                Password = Password,
                Name = Name,
                Email = Email,
            };

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
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
