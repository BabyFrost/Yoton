﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Yoton
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAccueil : ContentPage
    {
        public PageAccueil()
        {
            InitializeComponent();
        }
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SinscrireGratuit());
        }
    }
}