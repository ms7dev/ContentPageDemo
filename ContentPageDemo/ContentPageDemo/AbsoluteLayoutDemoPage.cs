﻿using System;
using Xamarin.Forms;

namespace ContentPageDemo
{
    class AbsoluteLayoutDemoPage : ContentPage
    {
        Label text1;
        Label text2;
        ContentView myView;
        bool isCurrentPage;

        public AbsoluteLayoutDemoPage()
        {
            Label header = new Label
            {
                Text = "AbsoluteLayout",
                Font = Font.SystemFontOfSize(40),
                HorizontalOptions = LayoutOptions.Center
            };

            AbsoluteLayout absoluteLayout = new AbsoluteLayout
            {
                BackgroundColor = Color.Blue.WithLuminosity(0.9),                
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Create two Labels for animating.
            text1 = new Label
            {
                Text = "AbsoluteLayout",
                TextColor = Color.Black
            };

            myView = new ContentView
            {
                BackgroundColor = Color.Aqua,
                Padding = new Thickness(25),
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label
                {
                    Text = "The ContentView (colored aqua in this " +
                           "example) might not seem very useful " +
                           "because it can have a single child " +
                           "(in this example a Label) and doesn't " +
                           "do much else. But ContentView is sometimes a " +
                           "convenient way of providing a background " +
                           "color or giving a little margin to its " +
                           "child through its own Padding property.",
                    TextColor = Color.Purple
                }
            };            

            //absoluteLayout.Children.Add(text1);

            absoluteLayout.Children.Add(myView);

            AbsoluteLayout.SetLayoutFlags(myView,
                AbsoluteLayoutFlags.PositionProportional);

            text2 = new Label
            {
                Text = "AbsoluteLayout",
                TextColor = Color.Black
            };
            absoluteLayout.Children.Add(text2);
            AbsoluteLayout.SetLayoutFlags(text2,
                AbsoluteLayoutFlags.PositionProportional);

            // Build the page.
            this.Content = new StackLayout
            {
                Children = 
                {
                    header,
                    absoluteLayout
                }
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            isCurrentPage = true;
            DateTime beginTime = DateTime.Now;

            Device.StartTimer(TimeSpan.FromSeconds(1.0 / 20), () =>
            {
                double seconds = (DateTime.Now - beginTime).TotalSeconds;
                double offset = 1 - Math.Abs((seconds % 2) - 1);

                AbsoluteLayout.SetLayoutBounds(myView,
                    new Rectangle(offset, offset,
                        AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                AbsoluteLayout.SetLayoutBounds(text2,
                    new Rectangle(1 - offset, offset,
                        AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                return isCurrentPage;
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            isCurrentPage = false;
        }
    }
}
