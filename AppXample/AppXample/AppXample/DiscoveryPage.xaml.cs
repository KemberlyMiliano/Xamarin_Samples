using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryPage : ContentPage
    {
        public DiscoveryPage()
        {
            InitializeComponent();

        }
        private void Stack_Clicked(object sender, EventArgs e)
        {
            beerStack.BackgroundColor = Color.FromHex("#F9A602");
            diningStack.BackgroundColor = Color.White;
            cafeStack.BackgroundColor = Color.White;
            nearbyStack.BackgroundColor = Color.White;
            foodStack.BackgroundColor = Color.White;
            pizzaStack.BackgroundColor = Color.White;
        }
        private void Stack_Clicked1(object sender, EventArgs e)
        {
            diningStack.BackgroundColor = Color.FromHex("#F9A602");
            beerStack.BackgroundColor = Color.White;
            cafeStack.BackgroundColor = Color.White;
            nearbyStack.BackgroundColor = Color.White;
            foodStack.BackgroundColor = Color.White;
            pizzaStack.BackgroundColor = Color.White;
        }
        private void Stack_Clicked2(object sender, EventArgs e)
        {
            cafeStack.BackgroundColor = Color.FromHex("#F9A602");
            diningStack.BackgroundColor = Color.White; ;
            beerStack.BackgroundColor = Color.White;
            nearbyStack.BackgroundColor = Color.White;
            foodStack.BackgroundColor = Color.White;
            pizzaStack.BackgroundColor = Color.White;
        }
        private void Stack_Clicked3(object sender, EventArgs e)
        {
            nearbyStack.BackgroundColor = Color.FromHex("#F9A602");
            cafeStack.BackgroundColor = Color.White;
            diningStack.BackgroundColor = Color.White; ;
            beerStack.BackgroundColor = Color.White;
            foodStack.BackgroundColor = Color.White;
            pizzaStack.BackgroundColor = Color.White;
        }
        private void Stack_Clicked4(object sender, EventArgs e)
        {
            foodStack.BackgroundColor = Color.FromHex("#F9A602");
            nearbyStack.BackgroundColor = Color.White;
            cafeStack.BackgroundColor = Color.White;
            diningStack.BackgroundColor = Color.White; ;
            beerStack.BackgroundColor = Color.White;
            pizzaStack.BackgroundColor = Color.White;
        }
        private void Stack_Clicked5(object sender, EventArgs e)
        {
            pizzaStack.BackgroundColor = Color.FromHex("#F9A602");
            foodStack.BackgroundColor = Color.White;
            nearbyStack.BackgroundColor = Color.White;
            cafeStack.BackgroundColor = Color.White;
            diningStack.BackgroundColor = Color.White; ;
            beerStack.BackgroundColor = Color.White;
        }

    }
}