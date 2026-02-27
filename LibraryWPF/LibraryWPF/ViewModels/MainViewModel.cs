using LibraryWPF.Commands;
using System.Windows.Input;

namespace LibraryWPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _currentViewModel;
        public BaseViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set { _currentViewModel = value; OnPropertyChanged(nameof(CurrentViewModel)); }
        }
        public string CurrentPageTitle { get; set; }
        public ICommand BooksCategoriesCommand { get; set; }
        public ICommand BooksCommand { get; set; }
        public ICommand BorrowBookCommand { get; set; }
        public ICommand ReturnBookCommand { get; set; }
        public ICommand UsersCommand { get; set; }
        public ICommand LogoutCommand { get; set; }

        private void BooksCategories(object? obj) => CurrentViewModel = new BooksCategoriesVM();
        private void Books(object? obj) => CurrentViewModel = new BooksVM();
        private void BorrowBook(object? obj) => CurrentViewModel = new BorrowBookVM();
        private void ReturnBook(object? obj) => CurrentViewModel = new ReturnBookVM();
        private void Users(object? obj) => CurrentViewModel = new UsersVM();
        private void Logout(object? obj) => CurrentViewModel = new LoginViewModel();

        public MainViewModel()
        {
            BooksCategoriesCommand = new Command(BooksCategories);
            BooksCommand = new Command(Books);
            BorrowBookCommand = new Command(BorrowBook);
            ReturnBookCommand = new Command(ReturnBook);
            UsersCommand = new Command(Users);
            LogoutCommand = new Command(Logout);

            CurrentViewModel = new BooksCategoriesVM();
        }
    }
}
