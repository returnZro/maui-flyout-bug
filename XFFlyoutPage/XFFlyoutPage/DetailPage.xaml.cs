using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFFlyoutPage
{    
    public partial class DetailPage : ContentPage
    {    
        public DetailPage ()
        {
            InitializeComponent ();
        }

        private void PushPage_OnClicked(object sender, EventArgs e)
        {
            Application.Current?.MainPage?.Navigation.PushAsync(new ContentToPush());
        }

        private void PushModal_OnClicked(object sender, EventArgs e)
        {
            Application.Current?.MainPage?.Navigation.PushModalAsync(new ContentToPush());
        }
    }
}

