using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFFlyoutPage
{    
    public partial class AppFlyout : FlyoutPage
    {    
        public AppFlyout ()
        {
            InitializeComponent ();

            var master = new MasterPage();
            var detail = new DetailPage();
            Flyout = master; // content page
            Detail = detail; // navigation page
        }
    }
}

