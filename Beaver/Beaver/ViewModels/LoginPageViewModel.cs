using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public LoginPageViewModel(INavigationService navigationService, IPageDialogService dialogService) : base(navigationService, dialogService)
        {
            Title = "LoginPage";
        }
        private async Task ExecuteNavigateCommand()
        {
            bool isEmailEmpty = string.IsNullOrEmpty(User);
            bool isPasswordEmpty = string.IsNullOrEmpty(Password);
            if (isEmailEmpty || isPasswordEmpty)
            {
                await _dialogService.DisplayAlertAsync("Falha ao entrar", "Email e senha precisam ser preenchidos", "OK");
            }
            else
            {
                //await NavigationService.NavigateAsync(nameof());
            }
        }

    }
}
