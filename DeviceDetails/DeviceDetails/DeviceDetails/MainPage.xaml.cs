using Xamarin.Forms;

namespace DeviceDetails
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var platformInfo = DependencyService.Get<IPlatformInfo>();
            ModelLabel.Text = platformInfo.GetModel();
            VersionLabel.Text = platformInfo.GetVersion();
        }
    }
}
