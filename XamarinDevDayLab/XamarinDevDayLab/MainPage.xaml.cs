using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDevDayLab
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();
            var employeeService = new Services.EmployService();
            ItemsSource = employeeService.GetAllEmployees();
            
        }

    }
}
