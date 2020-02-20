using AppXample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppXample.ViewModels
{
    public class SignUpPageViewModel
    {
        public User User { get; set; } = new User();
        public string DisplayErrorMessage { get; set; } = "";
        public ICommand SignUpCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand PasswordVisibilityCommand { get; set; }
        public SignUpPageViewModel()
        {

            SignUpCommand = new Command(async () =>
            {
                if (!string.IsNullOrEmpty(User.Username) && !string.IsNullOrEmpty(User.Email) && !string.IsNullOrEmpty(User.Password) && !string.IsNullOrEmpty(User.RepeatPassword))
                {
                    await App.Current.MainPage.Navigation.PushAsync(new MainPage());
                }

                else
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "All fields need to be filled", "OK");
                }

            });

            LoginCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new LoginPage());

            });

        }

    }
}
