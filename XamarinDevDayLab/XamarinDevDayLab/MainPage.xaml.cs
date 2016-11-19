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
