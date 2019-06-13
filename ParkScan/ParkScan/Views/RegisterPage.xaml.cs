using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkScan.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        //private string _userName;
        //private string _password;
        //private string _emailAddress;

        public string EmailAddress { get; set; }
        public string UsernameReg { get; set; }
        public string Password { get; set; }
        
        
        public RegisterPage()
        {
            InitializeComponent();

            UsernameReg = entryUsernameReg.Text;
        }

        private void BtnRegisterReg_Clicked(object sender, EventArgs e)
        {
            string username = entryUsernameReg.Text;
            var password = entryPasswordReg.Text;
            var passwordConfirm = entryConfirmPasswordReg.Text;
            string emailAddress = entryEmail.Text;

            if (String.IsNullOrEmpty(password) == false && String.IsNullOrEmpty(username) == false && password == passwordConfirm)
            {
                Password = password;
                UsernameReg = username;
                EmailAddress = emailAddress;

                Application.Current.MainPage = new LoginPage(username, emailAddress, password);
            }
            else
            {
                DisplayAlert("Alert", "Provide all fields and re-type password", "Re-Type");
            }
            
                
        }
    }
}