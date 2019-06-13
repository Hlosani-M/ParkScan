using ParkScan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkScan.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    
    public partial class MasterPage : ContentPage
    {
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public ListView ListView => menu_ListView;
        public MasterPage(string username, string email)
        {
            InitializeComponent();
            Username = username;
            EmailAddress = email;
            var menuItems = new List<MasterMenuItem>
            {
                new MasterMenuItem("Home", "homePink.png"),
                new MasterMenuItem("Account", "personPink.png"),
                new MasterMenuItem("Cards", "cardPink.png"),
                new MasterMenuItem("Prepaid", "prepaidPink.png"),
                new MasterMenuItem("History", "historyPink.png"),
                new MasterMenuItem("Rewards", "starPink.png"),
                new MasterMenuItem("Scan", "qrcodescanPink.png"),
                new MasterMenuItem("Share", "sharePink.png"),
                new MasterMenuItem("Help", "helpPink.png"),
                new MasterMenuItem("About", "aboutPink.png"),
                new MasterMenuItem("Sign Out", "logoutPink.png")
            };

            menu_ListView.ItemsSource = menuItems;
            BindingContext = this;

        }
    }
}