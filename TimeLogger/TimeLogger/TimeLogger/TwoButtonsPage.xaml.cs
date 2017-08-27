using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimeLogger
{
    public partial class TwoButtonsPage : ContentPage
    {
        private Button AddButton, RemoveButton;
        StackLayout LoggerLayout = new StackLayout();

        public TwoButtonsPage()
        {
            InitializeComponent();
            AddButton = new Button
            {
                Text = "Add",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            AddButton.Clicked += OnButtonClicked;
            RemoveButton = new Button
            {
                Text = "Remove",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                IsEnabled = false
            };
            RemoveButton.Clicked += OnButtonClicked;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    this.Padding = new Thickness(5, 5, 5, 0);
                    break;
                case Device.Android:
                    this.Padding = new Thickness(5, 5, 5, 0);
                    break;
                default:
                    this.Padding = new Thickness(5, 5, 5, 0);
                    break;
            }
            this.Content = new StackLayout
            {
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            AddButton,
                            RemoveButton
                        }
                    },
                    new ScrollView
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Content = LoggerLayout
                    }
                }
            };
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;

            if (button == AddButton)
            {
                LoggerLayout.Children.Add(new Label
                {
                    Text = "Button clicked at " + DateTime.Now.ToString("T")
                });

            }
            else
            {
                LoggerLayout.Children.RemoveAt(0);
            }
            RemoveButton.IsEnabled = LoggerLayout.Children.Count > 0;
        }
    }
}
