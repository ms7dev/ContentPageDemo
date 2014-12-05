using System;
using Xamarin.Forms;

namespace ContentPageDemo
{
    class DatePickerDemoPage : ContentPage
    {
        public DatePickerDemoPage()
        {
            Label header = new Label
            {
                Text = "DatePicker",
                Font = Font.SystemFontOfSize(50),
                HorizontalOptions = LayoutOptions.Center
            };

            DatePicker datePicker = new DatePicker
            {
                Format = "D",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            

            // Build the page.
            this.Content = new StackLayout
            {
                Children = 
                {
                    header,
                    datePicker
                }
            };
        }
    }
}