using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinDevDayLab
{
    public partial class NewsPage : ContentPage
    {
        public NewsPage()
        {
            InitializeComponent();
            this.queryBtn.Clicked += Querybtn_Clicked;
        }

        private void Querybtn_Clicked(object sender, EventArgs e)
        {
            this.DisplayAlert("Message", this.queryDate.Date.ToString(), "OK");
        }
    }
}
