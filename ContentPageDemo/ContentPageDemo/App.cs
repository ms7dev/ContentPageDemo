using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ContentPageDemo
{
    public class App
    {
        public static Page GetMainPage()
        {
            var Content = new NavigationPage(new NavigationPageDemoPage());            
            return Content;    
        }
    }
}
