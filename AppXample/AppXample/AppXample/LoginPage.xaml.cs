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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void SignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());

        }
        private void Login_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text))
            {
                DisplayAlert("Alert", "Please enter your username or email address", "OK");
            }
            else if (string.IsNullOrEmpty(password.Text))
            {
                DisplayAlert("Alert", "Please enter your password", "OK");
            }
            else if (string.IsNullOrEmpty(username.Text) && string.IsNullOrEmpty(password.Text))
            {
                DisplayAlert("Alert", "Please enter your username and password", "OK");
            }
            else
            {
                Navigation.PushAsync(new MainPage());

            }
        }
        void OnChangePasswordVisibility(System.Object sender, System.EventArgs e)
        {
            imageShowPassword.Source = !password.IsPassword ? "eyeIcon" : "closeEyeIcon";
            password.IsPassword = !password.IsPassword;

        }

    }
}