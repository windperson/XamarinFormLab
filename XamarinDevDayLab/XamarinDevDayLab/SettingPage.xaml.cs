using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using XamarinDevDayLab.Models;

namespace XamarinDevDayLab
{
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
            
            this.orientationBtn.Clicked += OrientationBtn_Clicked;
            this.cameraBtn.Clicked += async (object sender, EventArgs e) =>
            {
                //fix for running on UWP, see http://stackoverflow.com/a/40493013/1075882
                var libStatus = await CrossMedia.Current.Initialize();
                if (!libStatus)
                {
                    DisplayAlert("lib init", "lib init error", "OK");
                    return;
                }
                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    DisplayAlert("No Camera", "No Camera available", "OK");
                    return;
                }
                var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    Directory = "Sample",
                    Name = "test.jpg"
                });

                if (file == null)
                {
                    //TODO: should notify that take "no" picture to user?
                    return;
                }
                DisplayAlert("Pic file location", file.Path, "OK");

                this.myImg.Source = ImageSource.FromStream(() =>
                {
                    var stream = file.GetStream();
                    file.Dispose();
                    return stream;
                });
            };

        }

        private void OrientationBtn_Clicked(object sender, EventArgs e)
        {
            var orientation = DependencyService.Get<IDeviceOrientation>().GetOrientation();
            switch (orientation)
            {
                case DeviceOrientations.Undefined:
                    DisplayAlert("Message", "Undefined?!", "OK");
                    break;
                case DeviceOrientations.Landscape:
                    DisplayAlert("Message", "Landscape!", "OK");
                    break;
                case DeviceOrientations.Portrait:
                    DisplayAlert("Message", "Portrait!", "OK");
                    break;
            }

        }
    }
}
