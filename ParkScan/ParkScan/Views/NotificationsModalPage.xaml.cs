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
    public partial class NotificationsModalPage : ContentPage
    {
        public NotificationsModalPage()
        {
            InitializeComponent();
        }

        async void DismissButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}