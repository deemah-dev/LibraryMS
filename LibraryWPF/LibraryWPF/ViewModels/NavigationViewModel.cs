using LibraryWPF.Commands;
using System.Windows.Input;

namespace LibraryWPF.ViewModels
{
    class NavigationViewModel : BaseViewModel
    {
        private object _currentViewModel;
        public object CurrentViewModel
        {
            get { return _currentViewModel; }
            set { _currentViewModel = value; OnPropertyChanged(nameof(CurrentViewModel)); }
        }

        public ICommand LoginPageCommand { get; set; }
        public ICommand HomeCommand { get; set; }

        private void Login(object? obj) => CurrentViewModel = new LoginViewModel();
        private void Home(object? obj) => CurrentViewModel = new MainViewModel();

        public NavigationViewModel()
        {
            LoginPageCommand = new Command(Login);
            HomeCommand = new Command(Home);

            // Startup Page
            CurrentViewModel = new MainViewModel();
        }
    }
}
