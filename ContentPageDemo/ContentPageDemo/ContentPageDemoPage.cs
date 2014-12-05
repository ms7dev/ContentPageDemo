using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace ContentPageDemo
{
    class ContentPageDemoPage : ContentPage
    {
        public ContentPageDemoPage()
        {
            Label header = new Label
            {
                Text = "ContentPage",
                Font = Font.SystemFontOfSize(40),
                HorizontalOptions = LayoutOptions.Center
            };

            Label label1 = new Label
            {
                Text = "ContentPage is the simplest type of page.",
                Font = Font.SystemFontOfSize(NamedSize.Large)
            };

            Label label2 = new Label
            {
                Text = "The content of a ContentPage is generally a " +
                       "layout of some sort that can then be a parent " +
                       "to multiple children.",
                Font = Font.SystemFontOfSize(NamedSize.Large)
            };

            Label label3 = new Label
            {
                Text = "This ContentPage contains a StackLayout, which " +
                       "in turn contains four Label views (including the " +
                       "large one at the top)",
                Font = Font.SystemFontOfSize(NamedSize.Large)
            };

            Button button1 = new Button
            {
                StyleId = "butSave",
                Text = "Go to Label Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            var myImage = new Image();
            myImage.Source = FileImageSource.FromFile("icon.png");
            myImage.Aspect = Aspect.AspectFit;





            //Content = new AbsoluteLayout
            //{
            //    Children = {
            //        {myImage, new Rectangle (0, 0, 1, 1), AbsoluteLayoutFlags.All}

            //    }
            //};


            //Build the page.
            this.Content = new StackLayout
            {
                Children = 
                {
                    header,
                    myImage,
                    button1
                }
            };

            //this.Content.BackgroundColor = Color.FromHex("#FF765D7B");


        }
    }
}