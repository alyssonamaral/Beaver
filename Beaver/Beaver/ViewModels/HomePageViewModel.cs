using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Beaver.Models;

namespace Beaver.ViewModels
{
    public class HomePageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Stories> Stories;

        public ObservableCollection<Stories> stories
        {
            get { return Stories; }
            set
            {
                Stories = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("stories"));
            }
        }
        public HomePageViewModel(INavigationService navigationService, IPageDialogService dialogService) : base(navigationService, dialogService)
        {
            stories = new ObservableCollection<Stories>();
            addData();
        }

        private void addData()
        {
            stories.Add(new Stories
            {
                id = 0,
                title = "A Night Tale: Origin",
                bookCover = "https://i1.sndcdn.com/artworks-000299554542-yc9iwn-t500x500.jpg"
            });

            stories.Add(new Stories
            {
                id = 1,
                title = "Luna",
                bookCover = "https://images.fineartamerica.com/images/artworkimages/mediumlarge/1/luna-edward-burne-jones.jpg"
            });

            stories.Add(new Stories
            {
                id = 2,
                title = "Architecure Girl",
                bookCover = "https://cdn.culturagenial.com/imagens/zodiac-mucha.jpg"
            });

            stories.Add(new Stories
            {
                id = 1,
                title = "Chapter 13: Love Story",
                bookCover = "https://i.pinimg.com/originals/ab/91/51/ab915112dbade8b6a7e780eb1d16db48.jpg"
            });
        }
    }
}
