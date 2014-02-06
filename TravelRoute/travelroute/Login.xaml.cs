using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.WindowsAzure.MobileServices;

namespace travelroute
{
    public partial class Login : PhoneApplicationPage
    {

        public Login()
        {
            InitializeComponent();
        }
        private async void facebookLoginButton_Click(object sender, RoutedEventArgs e)
        {
            await AuthenticateWithFacebook();
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private async void twitterLoginButton_Click(object sender, RoutedEventArgs e)
        {
            await AuthenticateWithTwitter();
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private async System.Threading.Tasks.Task AuthenticateWithFacebook()
        {
            while (App.MobileService.CurrentUser == null)
            {
                string message;
                try
                {
                    App.MobileService.CurrentUser = await App.MobileService.LoginAsync(MobileServiceAuthenticationProvider.Facebook);
                    message = string.Format("You are now logged in - {0}", App.MobileService.CurrentUser.UserId);
                }
                catch (InvalidOperationException)
                {
                    message = "You must log in. Login Required";
                }

                MessageBox.Show(message);
            }
        }

        private async System.Threading.Tasks.Task AuthenticateWithTwitter()
        {
            while (App.MobileService.CurrentUser == null)
            {
                string message;
                try
                {
                    App.MobileService.CurrentUser = await App.MobileService.LoginAsync(MobileServiceAuthenticationProvider.Twitter);
                    message = string.Format("You are now logged in - {0}", App.MobileService.CurrentUser.UserId);
                }
                catch (InvalidOperationException)
                {
                    message = "You must log in. Login Required";
                }

                MessageBox.Show(message);
            }
        }
    }
}