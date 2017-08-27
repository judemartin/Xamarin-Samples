using Android.OS;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceDetails.Droid.PlatformInfo))]
namespace DeviceDetails.Droid
{
    public class PlatformInfo: IPlatformInfo
    {
        public string GetModel()
        {
            return $"{Build.Manufacturer}, {Build.Model}";
        }

        public string GetVersion()
        {
            return Build.VERSION.Release;
        }
    }
}