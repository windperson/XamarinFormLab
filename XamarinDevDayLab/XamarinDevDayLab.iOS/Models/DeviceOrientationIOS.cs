using System;
using XamarinDevDayLab.Models;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinDevDayLab.iOS.Models.DeviceOrientationIOS))]
namespace XamarinDevDayLab.iOS.Models
{
	public class DeviceOrientationIOS : IDeviceOrientation
	{
		public DeviceOrientations GetOrientation()
		{
			var deviceOrientation = UIDevice.CurrentDevice.Orientation;

			switch (deviceOrientation)
			{
				case UIDeviceOrientation.Portrait:
				case UIDeviceOrientation.PortraitUpsideDown:
					{
						return DeviceOrientations.Portrait;
					}
				case UIDeviceOrientation.LandscapeLeft:
				case UIDeviceOrientation.LandscapeRight:
					{
						return DeviceOrientations.Landscape;
					}
				default:
					{
						return DeviceOrientations.Undefined;
					}					
			}
		}
	}
}
