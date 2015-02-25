using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinPresentation1.Views
{
    public class TabPage : TabbedPage
    {
        public TabPage()
        {
            Children.Add(new FirstTabPage());
            Children.Add(new SecondTabPage());
        }
    }
}
