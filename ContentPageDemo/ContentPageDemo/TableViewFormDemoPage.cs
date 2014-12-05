using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContentPageDemo
{
    class TableViewFormDemoPage : ContentPage
    {
        public TableViewFormDemoPage()
        {
            Label header = new Label
            {
                Text = "TableView for a form",
                Font = Font.SystemFontOfSize(30),
                HorizontalOptions = LayoutOptions.Center
            };

            TableView tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("TableView Title")
                {
                    new TableSection("Table Section")
                    {
                        new TextCell
                        {
                            Text = "Text Cell",
                            Detail = "With Detail Text",
                        },
                        new ImageCell
                        {
                            // Some differences with loading images in initial release.
                            ImageSource = 
                                Device.OnPlatform(ImageSource.FromFile("icon.png"),
                                                  ImageSource.FromFile("icon.png"),
                                                  ImageSource.FromFile("icon.png")),
                            Text = "Image Cell",
                            Detail = "With Detail Text",
                        },
                        new SwitchCell
                        {
                            Text = "Switch Cell"
                        },
                        new EntryCell
                        {
                            Label = "Entry Cell",
                            Placeholder = "Type text here"
                        },
                        new ViewCell
                        {
                            View = new StackLayout
                            {
                                Orientation = StackOrientation.Horizontal,
                                Children = 
                                {
                                    new Label
                                    {
                                        Text = "Custom Slider View:"
                                    },
                                    new Slider
                                    {
                                    }
                                }
                            }
                        },
                        new ViewCell
                        {
                            View = new Label
                            {
                                Text = "A View Cell can be anything you want!"
                            }
                        }
                    }
                }
            };

            // Build the page.
            this.Content = new StackLayout
            {
                Children = 
                {
                    header,
                    tableView
                }
            };
        }
    }
}
