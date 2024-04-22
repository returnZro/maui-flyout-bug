using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFFlyoutPage
{    
    public partial class ContentToPush : ContentPage
    {    
        public ContentToPush ()
        {
            InitializeComponent ();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            if (Application.Current?.MainPage?.Navigation.ModalStack.Count > 0)
            {
                Application.Current.MainPage.Navigation.PopModalAsync();
            }
            else
            {
                Application.Current?.MainPage?.Navigation.PopAsync();
            }
        }
    }
}

