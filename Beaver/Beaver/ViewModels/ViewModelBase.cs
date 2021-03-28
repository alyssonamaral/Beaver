using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Beaver.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private ImageSource _logo;
        public ImageSource Logo
        {
            get { return _logo; }
            set => SetProperty(ref _logo, value);
        }


        public virtual Task InitializeAsync(INavigationParameters parameters)
      => Task.CompletedTask;
        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        protected readonly INavigationService NavigationService;
        protected readonly IPageDialogService _dialogService;
        public ViewModelBase(INavigationService navigationService, IPageDialogService dialogService)
        {
            NavigationService = navigationService;
            _dialogService = dialogService; 
            Logo = ImageSource.FromResource("Beaver.Assets.Images.beaverLogo.png");
        }

        public virtual void Initialize(INavigationParameters parameters)
        {

        }
        public virtual void Destroy()
        {

        }
    }
}
