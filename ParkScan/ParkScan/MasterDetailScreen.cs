using ParkScan.Model;
using ParkScan.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace ParkScan
{
    public class MasterDetailScreen : MasterDetailPage
    {
        MasterPage masterPage;
        ZXingScannerPage scanPage;

        public MasterDetailScreen(string username, string email)
        {
            masterPage = new MasterPage(username, email);
            Master = masterPage;
            Detail = new NavigationPage(new HomePage());

            masterPage.menu_ListView.ItemSelected += Menu_ListView_ItemSelected;
        }

        void Menu_ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var itemclicked = new MasterMenuItem();
            var item = e.SelectedItem as MasterMenuItem;
            //item = itemclicked;
                      
            ContentPage page = null;
            if (item != null)
            {
                switch (item.MenuItemName)
                {
                    case "Home":
                        page = new HomePage();
                        break;
                    case "Account":
                        page = new AccountPage();
                        break;
                    case "Cards":
                        page = new AddCardPage();
                        break;
                    case "Prepaid":
                        page = new AddCardPage();
                        break;
                    case "History":
                        page = new HistoryPage();
                        break;
                    case "Rewards":
                        page = new RewardsPage();
                        break;
                    case "Scan":
                        scanPage = new ZXingScannerPage();
                        page = scanPage;
                        scanPage.OnScanResult += async (result) =>
                        {
                            scanPage.IsScanning = false;

                            Device.BeginInvokeOnMainThread(() =>
                            {
                                Navigation.PopAsync();
                                DisplayAlert("Scanned Barcode", result.Text, "OK");
                            });
                            await Navigation.PushAsync(scanPage);
                        };
                        //page = new ScanPage();
                        break;
                    case "Share":
                        page = new SharePage();
                        break;
                    case "Help":
                        page = new HelpPage();
                        break;
                    case "About":
                        page = new AboutPage();
                        break;
                    case "Sign Out":
                        page = new LoginPage();
                        break;
                    default:
                        page = new LoginPage();
                        break;
                }
                Detail = new NavigationPage(page);
                masterPage.menu_ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
