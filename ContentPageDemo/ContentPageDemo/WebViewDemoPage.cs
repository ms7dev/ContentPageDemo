using System;
using Xamarin.Forms;

namespace ContentPageDemo
{
    class WebViewDemoPage : ContentPage
    {
        public WebViewDemoPage()
        {
            Label header = new Label
            {
                Text = "WebView",
                Font = Font.SystemFontOfSize(50),
                HorizontalOptions = LayoutOptions.Center
            };

            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "http://blog.xamarin.com/",
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Build the page.
            this.Content = new StackLayout
            {
                Children = 
                {
                    header,
                    webView
                }
            };
        }
    }
}
