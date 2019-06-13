using ParkScan.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkScan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public LoginPage()
        {
            InitializeComponent();
        }
        public LoginPage(string username, string emailAddress, string password)
        {
            InitializeComponent();

            Username = username;
            EmailAddress = emailAddress;
            Password = password;

            txtf_username.Text = username;
            
            BindingContext = new RegisterPage();
        }

        void Btn_SignIn_Clicked(object sender, EventArgs e)
        {
            Username = txtf_username.Text;
            var _password = txtf_password.Text;

            if (_password == Password)
            {
                Application.Current.MainPage = new MasterDetailScreen(Username, EmailAddress); //sets the root page
            }
            else
            {
                DisplayAlert("Wrong Password", "Enter correct password", "OK");
            }
            
            //Navigation.InsertPageBefore(new MasterDetailScreen(),this);
            //await Navigation.PopAsync();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {

        }
    }
}