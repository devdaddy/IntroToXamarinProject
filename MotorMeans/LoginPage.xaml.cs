using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MotorMeans
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void GoToRegistrationPage(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new RegistrationPage()));
        }

        async void Login(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Home()));
        }
    }
}
