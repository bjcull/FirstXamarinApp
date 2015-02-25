using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinPresentation1.ViewModels;

namespace XamarinPresentation1.Views
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "My First App";
            Content = GetContent();
            BindingContext = App.MainPageVm;
        }

        private View GetContent()
        {
            var username = new Entry()
            {
                Placeholder = "username"
            };
            username.SetBinding<MainPageVm>(Entry.TextProperty, x => x.Username);

            var password = new Entry()
            {
                Placeholder = "password",
                IsPassword = true
            };
            password.SetBinding<MainPageVm>(Entry.TextProperty, x => x.Password);

            var loginButton = new Button()
            {
                Text = "Login"
            };
            loginButton.Clicked += async (sender, args) =>
            {
                var result = App.MainPageVm.Login();
                if (result)
                {
                    await Navigation.PushAsync(new TabPage());
                }
                else
                {
                    await DisplayAlert("Login Failed", "Please check your details and try again", "OK", null);
                }
            };

            var stack = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness(20, 0),
                Children =
                {
                    username,
                    password,
                    loginButton
                }
            };

            return stack;
        }
    }
}
