using System;
using Xamarin.Forms;

namespace ContentPageDemo
{
    class ImageDemoPage : ContentPage
    {
        public ImageDemoPage()
        {
            Label header = new Label
            {
                Text = "Image",
                Font = Font.SystemFontOfSize(50),
                HorizontalOptions = LayoutOptions.Center
            };

            Image image = new Image
            {
                // Some differences with loading images in initial release.
                //Source =
                //    Device.OnPlatform(ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")),
                //                      ImageSource.FromFile("hero-slide.jpg"),
                //                      ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png"))),

                Source = "icon.png",

                //Source = new UriImageSource
                //{
                //    Uri = new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")
                //},
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Build the page.
            this.Content = new StackLayout
            {
                Children = 
                {
                    header,
                    image
                }
            };
        }
    }
}