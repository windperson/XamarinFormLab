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
            this.cameraBtn.Clicked += CameraBtn_Clicked;
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

        private async void CameraBtn_Clicked(object sender, EventArgs e)
        {
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

        }
    }
}
