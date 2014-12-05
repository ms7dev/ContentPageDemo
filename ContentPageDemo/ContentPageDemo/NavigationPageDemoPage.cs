using System;
using Xamarin.Forms;

namespace ContentPageDemo
{
    // Although this page is actually a ContentPage, it can 
    //  function as a NavigationPage because the HomePage
    //  is launched as an ApplicationPage in App. 
    class NavigationPageDemoPage : ContentPage
    {
        public NavigationPageDemoPage()
        {
            Label header = new Label
            {
                Text = "NavigationPage",
                Font = Font.SystemFontOfSize(40),
                HorizontalOptions = LayoutOptions.Center
            };           

            Button ButLabel = new Button
            {
                Text = "Go to Label Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };
            ButLabel.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new LabelDemoPage());

            Button ButContent = new Button
            {
                Text = "Go to ContentPage Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };
            ButContent.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new ContentPageDemoPage());

            Button ButMasterDetail = new Button
            {
                Text = "Go to MasterDetailPage Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };
            ButMasterDetail.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new MasterDetailPageDemoPage());

            Button ButImage = new Button
            {
                Text = "Go to Image Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };
            ButImage.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new ImageDemoPage());

            Button ButBoxView = new Button
            {
                Text = "Go to BoxView Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };
            ButBoxView.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new BoxViewDemoPage());

            Button ButWebView = new Button
            {
                Text = "Go to WebView Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };
            ButWebView.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new WebViewDemoPage());

            Button ButTabPage = new Button
            {
                Text = "Go to TabbedPage Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };
            ButTabPage.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new TabbedPageDemoPage());

            Button ButCarouselPage = new Button
            {
                Text = "Go to CarouselPage Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };
            ButCarouselPage.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new CarouselPageDemoPage());

            Button ButContentView = new Button
            {
                Text = "Go to ContentView Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };
            ButContentView.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new ContentViewDemoPage());

            Button ButScrollView = new Button
            {
                Text = "Go to ScrollView Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };
            ButScrollView.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new ScrollViewDemoPage());

            Button ButAbsLayoutView = new Button
            {
                Text = "Go to AbsoluteLayout Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };
            ButAbsLayoutView.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new AbsoluteLayoutDemoPage());

            Button BuGrid = new Button
            {
                Text = "Go to Grid Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };
            BuGrid.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new GridDemoPage());

            Button ButDatePicker = new Button
            {
                Text = "Go to DatePicker Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };
            ButDatePicker.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new DatePickerDemoPage());

            Button ButEntry = new Button
            {
                Text = "Go to Entry Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };

            ButEntry.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new EntryDemoPage());

            Button ButTableView = new Button
            {
                Text = "Go to TableView Demo Page ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1
            };
            ButTableView.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new TableViewFormDemoPage());

            StackLayout stack = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Children = 
                {
                    ButContent,
                    //ButLabel,
                    ButImage,
                    ButBoxView,
                    ButWebView,
                    ButTabPage,
                    ButCarouselPage,
                    ButMasterDetail,
                    ButContentView,
                    ButScrollView,
                    ButAbsLayoutView,
                    BuGrid,
                    ButDatePicker,
                    ButEntry,
                    ButTableView

                }
            };

            ScrollView homeView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = stack
            };

            // Build the page.
            this.Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = 
                {
                    header,
                    homeView                   
                }
            };
        }
    }
}
