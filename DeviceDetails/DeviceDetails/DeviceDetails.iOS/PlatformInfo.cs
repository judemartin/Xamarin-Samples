using System;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceDetails.iOS.PlatformInfo))]
namespace DeviceDetails.iOS
{
    public class PlatformInfo : IPlatformInfo
    {
        public readonly UIDevice Device = new UIDevice();
        public string GetModel()
        {
            return Device.Model;
        }

        public string GetVersion()
        {
            return $"{Device.SystemName}, {Device.SystemVersion}";
        }
    }
}