using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDevDayLab
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.AgeInput.ValueChanged += AgeInput_ValueChanged;
            this.SaveBtn.Clicked += SaveBtn_Clicked;
            this.DialBtn.Clicked += DialBtn_Clicked;
        }

        private async void DialBtn_Clicked(object sender, EventArgs e)
        {
            var dialStr = this.DialInput.Text;
            if(!String.IsNullOrEmpty(dialStr) 
                && await this.DisplayAlert("Dial Out","Call out to: \""+ this.DialInput.Text + "\" ?","YES","NO" ))
            {
                Device.OpenUri(new Uri("tel://"+dialStr));
            }
        }

        private void SaveBtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Message", "Save Data", "OK");
        }

        private void AgeInput_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.AgeVal.Text = this.AgeInput.Value.ToString("N0");
        }
    }
}
