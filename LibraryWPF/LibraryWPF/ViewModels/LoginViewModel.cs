using LibraryWPF.Commands;
using System.Windows.Input;

namespace LibraryWPF.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private BaseViewModel _currentViewModel;
        public BaseViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set { _currentViewModel = value; OnPropertyChanged(nameof(CurrentViewModel)); }
        }
        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        private bool _remeberMe;
        public bool RememberMe
        {
            get => _remeberMe;
            set
            {
                if (_remeberMe != value)
                {
                    _remeberMe = value;
                    OnPropertyChanged(nameof(RememberMe));
                }
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }
        public bool LoginSuccess(object? obj)
        {
            return (Username == "Admin");
        }

        public void LoginExecute(object? obj)
        {
            CurrentViewModel = new MainViewModel();
        }

        private ICommand _loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                if (_loginCommand is null)
                    _loginCommand = new Command(LoginExecute, LoginSuccess);
                return _loginCommand;
            }
        }
    }
}
