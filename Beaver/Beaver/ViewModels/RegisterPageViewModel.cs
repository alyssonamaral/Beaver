using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beaver.ViewModels
{
    public class RegisterPageViewModel : ViewModelBase
    {
        public RegisterPageViewModel(INavigationService navigationService, IPageDialogService dialogService) : base(navigationService, dialogService)
        {
        }
    }
}
