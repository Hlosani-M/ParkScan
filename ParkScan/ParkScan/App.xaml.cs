﻿using ParkScan.Views;
using System;
using Xamarin.Forms;

using Xamarin.Forms.Xaml;

namespace ParkScan
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MasterDetailScreen();
            //MainPage = new SplashPage();
            MainPage = new NavigationPage(new RegisterPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
