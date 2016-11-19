using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinDevDayLab.Models;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinDevDayLab.UWP.Models.DeviceOrientationUWP))]
namespace XamarinDevDayLab.UWP.Models
{
    public class DeviceOrientationUWP : IDeviceOrientation
    {
        public DeviceOrientations GetOrientation()
        {
            var orientation = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().Orientation;
            if (orientation == Windows.UI.ViewManagement.ApplicationViewOrientation.Landscape)
            {
                return DeviceOrientations.Landscape;
            }
            else
            {
                return DeviceOrientations.Portrait;
            }

        }
    }
}
