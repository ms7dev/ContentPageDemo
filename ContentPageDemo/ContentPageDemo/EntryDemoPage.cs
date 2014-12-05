using System;
using Xamarin.Forms;

namespace ContentPageDemo
{
    class EntryDemoPage : ContentPage
    {
        public EntryDemoPage()
        {
            Label header = new Label
            {
                Text = "Entry",
                Font = Font.SystemFontOfSize(50),
                HorizontalOptions = LayoutOptions.Center
            };

            Entry email = new Entry
            {
                Keyboard = Keyboard.Email,
                Placeholder = "Enter email address",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Entry text = new Entry
            {
                Keyboard = Keyboard.Text,
                Placeholder = "Enter password",
                IsPassword = true,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Entry tellephone = new Entry
            {
                Keyboard = Keyboard.Telephone,
                Placeholder = "Enter phone number",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };



            // Build the page.
            this.Content = new StackLayout
            {
                Children = 
                {
                    header,
                    email,
                    text,
                    tellephone
                    
                }
            };
        }
    }
}