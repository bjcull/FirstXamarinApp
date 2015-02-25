using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinPresentation1.Views
{
    public class SecondTabPage : ContentPage
    {
        public SecondTabPage()
        {
            Title = "Second Tab";
            Content = GetContent();
        }

        private View GetContent()
        {
            var label = new Label()
            {
                Text = "Second Tab"
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
