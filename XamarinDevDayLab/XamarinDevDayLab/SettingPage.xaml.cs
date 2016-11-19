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
