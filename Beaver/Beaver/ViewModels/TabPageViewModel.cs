using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;


namespace Beaver.ViewModels
{
    public class TabPageViewModel : ViewModelBase
    {
        public TabPageViewModel(INavigationService navigationService, IPageDialogService dialogService) : base(navigationService, dialogService)
        {
        }
    }
}
