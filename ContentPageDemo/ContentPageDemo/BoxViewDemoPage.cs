﻿using System;
using Xamarin.Forms;

namespace ContentPageDemo
{
    class BoxViewDemoPage : ContentPage
    {
        public BoxViewDemoPage()
        {
            Label header = new Label
            {
                Text = "BoxView",
                Font = Font.SystemFontOfSize(50),
                HorizontalOptions = LayoutOptions.Center
            };

            BoxView boxView = new BoxView
            {
                Color = Color.Accent,
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Build the page.
            this.Content = new StackLayout
            {
                Children = 
                {
                    header,
                    boxView
                }
            };
        }
    }
}
