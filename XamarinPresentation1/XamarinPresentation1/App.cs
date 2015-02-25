using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinPresentation1.ViewModels;
using XamarinPresentation1.Views;

namespace XamarinPresentation1
{
    public class App
    {
        public static MainPageVm MainPageVm = new MainPageVm();

        public static Page GetMainPage()
        {
            return new NavigationPage((new MainPage()));
        }
    }
}
