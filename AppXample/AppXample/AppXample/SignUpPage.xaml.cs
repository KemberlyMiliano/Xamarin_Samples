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
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        private async void Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        void SignUp_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(email.Text) && !string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(password.Text) && !string.IsNullOrEmpty(passwordCheck.Text))
            {
                Navigation.PushAsync(new MainPage());
            }

            else
            {
                DisplayAlert("Alert", "All camps need to be filled", "OK");
            }
        }

        void Terms_Clicked(object sender, EventArgs e)
        {

        }
    }
}