﻿using ParkScan.Views;
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
    public partial class TopupPage : ContentPage
    {
        public TopupPage()
        {
            InitializeComponent();
        }

        async void Btn_Home_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}