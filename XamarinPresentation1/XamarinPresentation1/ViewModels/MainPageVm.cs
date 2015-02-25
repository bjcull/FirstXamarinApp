using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinPresentation1.ViewModels
{
    public class MainPageVm
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool Login()
        {
            return Username == "ben" && Password == "password";
        }
    }
}
