using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using AppMenuItem = XamarinDevDayLab.Models.AppMenuItem;

namespace XamarinDevDayLab
{
    public partial class MenuPage : ContentPage
    {
        public ListView MenuListItems { get { return this.MenuItems; } }
        public MenuPage()
        {
            InitializeComponent();

            ObservableCollection<AppMenuItem> menuItems = new ObservableCollection<AppMenuItem>() {
                new AppMenuItem {Name= "EmpList", Icon = "", No = 1 },
                new AppMenuItem { Name = "News", Icon = "",No=2 },
                new AppMenuItem { Name = "Setting", Icon = "",No=3 }
            };

            this.MenuItems.ItemsSource = menuItems;
        }
    }
}
