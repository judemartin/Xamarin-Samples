using Xamarin.Forms;

namespace OpacityDataBinding
{
    public partial class OpacityBindingCodePage : ContentPage
    {
        public OpacityBindingCodePage()
        {
            InitializeComponent();

            Label label = new Label
            {
                Text = "Opacity Binding Demo",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            Slider slider = new Slider
            {
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            //target and source: 
            label.BindingContext = slider;
            // binding the label property: target is Opacity and the source is Value
            label.SetBinding(Label.OpacityProperty, "Value");

            Padding = new Thickness(10, 0);
            Content = new StackLayout
            {
                Children = { label, slider }
            };
        }
    }
}
