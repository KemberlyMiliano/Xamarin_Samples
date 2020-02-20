using AppXample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppXample.ViewModels
{
    public class DiscoveryPageViewModel : INotifyPropertyChanged
    {

        DiscoveryButtonView lastElementSelected = new DiscoveryButtonView();
        public ICommand LoginCommand { get; set; }
        public MenuOptions MenuOptionBeer { get; set; } = new MenuOptions();
        public MenuOptions MenuOptionDining { get; set; } = new MenuOptions();
        public MenuOptions MenuOptionCafe { get; set; } = new MenuOptions();
        public MenuOptions MenuOptionNearby { get; set; } = new MenuOptions();
        public MenuOptions MenuOptionFastFood { get; set; } = new MenuOptions();
        public MenuOptions MenuOptionFeaturedFood { get; set; } = new MenuOptions();

        public DiscoveryPageViewModel()
        {
            MenuOptionBeer.BackgroundColor = "White";
            MenuOptionBeer.ImageSource = "beerIcon";
            MenuOptionBeer.Title = "Bar and Hotels";
            MenuOptionBeer.Subtitle = "42 Place";

            MenuOptionDining.BackgroundColor = "White";
            MenuOptionDining.ImageSource = "fineDiningIcon";
            MenuOptionDining.Title = "Fine Dining";
            MenuOptionDining.Subtitle = "15 Place";

            MenuOptionCafe.BackgroundColor = "White";
            MenuOptionCafe.ImageSource = "cafesIcon";
            MenuOptionCafe.Title = "Cafes";
            MenuOptionCafe.Subtitle = "28 Place";

            MenuOptionNearby.BackgroundColor = "White";
            MenuOptionNearby.ImageSource = "nearbyIcon";
            MenuOptionNearby.Title = "Nearby";
            MenuOptionNearby.Subtitle = "34 Place";

            MenuOptionFastFood.BackgroundColor = "White";
            MenuOptionFastFood.ImageSource = "fastFoodIcon";
            MenuOptionFastFood.Title = "Fast Foods";
            MenuOptionFastFood.Subtitle = "29 Place";

            MenuOptionFeaturedFood.BackgroundColor = "White";
            MenuOptionFeaturedFood.ImageSource = "izzaIcon";
            MenuOptionFeaturedFood.Title = "Featured Foods";
            MenuOptionFeaturedFood.Subtitle = "21 Place";

            LoginCommand = new Command<object>((sender) =>
            {
                lastElementSelected.BackgroundColor = Color.White;
                var elementSelected = (DiscoveryButtonView)sender;
                elementSelected.BackgroundColor = Color.FromHex("#F9A602");
                lastElementSelected = elementSelected;

            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}



