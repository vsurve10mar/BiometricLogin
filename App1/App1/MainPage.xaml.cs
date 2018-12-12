using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            bool canFingerprint = DependencyService.Get<Interface.IAuthentication>().IsFingerprintAuthenticationPossible();
            if (canFingerprint)
            {
                DependencyService.Get<Interface.IAuthentication>().Authenticate();
            }
        }
    }
}
