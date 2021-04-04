using Beaver.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Beaver.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private string _user;
        public string User
        {
            get { return _user; }
            set => SetProperty(ref _user, value);
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set => SetProperty(ref _password, value);
        }

        DelegateCommand _navigateCommand;
        public DelegateCommand NavigateCommand => _navigateCommand
            ?? (_navigateCommand = new DelegateCommand(async () => await ExecuteNavigateCommand()));

        DelegateCommand _navigateRegisterCommand;
        public DelegateCommand NavigateRegisterCommand => _navigateRegisterCommand
            ?? (_navigateRegisterCommand = new DelegateCommand(async () => await ExecuteNavigateRegisterCommand()));

        private async Task ExecuteNavigateRegisterCommand()
        {
            await _navigationService.NavigateAsync(nameof(RegisterPage));
        }

        public LoginPageViewModel(INavigationService navigationService, IPageDialogService dialogService) : base(navigationService, dialogService)
        {
            Title = "LoginPage";
        }
        private async Task ExecuteNavigateCommand()
        {
            bool isUserEmpty = string.IsNullOrEmpty(User);
            bool isPasswordEmpty = string.IsNullOrEmpty(Password);
            if (isUserEmpty || isPasswordEmpty)
            {
                await _dialogService.DisplayAlertAsync("Hey", "You need to put a user and password valid", "OK");
            }
            else
            {
                await _navigationService.NavigateAsync(nameof(TabPage));
            }
        }
    }
}
