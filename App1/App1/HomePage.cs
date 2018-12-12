using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Login Successfully" }
                }
            };
        }
    }
}