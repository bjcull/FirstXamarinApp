using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinPresentation1.Views
{
    public class FirstTabPage : ContentPage
    {
        public FirstTabPage()
        {
            Title = "First Tab";
            Content = GetContent();
        }

        private View GetContent()
        {
            var label = new Label()
            {
                Text = "First Tab"
            };

            var stack = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    label
                }
            };

            return stack;
        }
    }
}
