using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace ParkScan.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        ZXingScannerPage scanPage;
        public HomePage()
        {
            InitializeComponent();
        }

        async void Btn_AddCard_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddCardPage());
        }

        async void Btn_TopUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TopupPage());
        }

        //async void Btn_Master_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new MasterPage());
        //}

        async void ScanHomeIcon_Clicked(object sender, EventArgs e)
        {
            scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) =>
            {
                scanPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopAsync();
                    DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };

            await Navigation.PushAsync(scanPage);
        }

        async void NotificationsIcon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NotificationsModalPage());
        }
    }
}