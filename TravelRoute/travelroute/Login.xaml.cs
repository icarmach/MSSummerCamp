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
            //Awaits for the facebook login and the redirects the user to the Home layout
            await AuthenticateWithFacebook();
            NavigationService.Navigate(new Uri("/Home.xaml", UriKind.Relative));
        }

        private async void twitterLoginButton_Click(object sender, RoutedEventArgs e)
        {
            //Awaits for the twitter login and the redirects the user to the Home layout
            await AuthenticateWithTwitter();
            NavigationService.Navigate(new Uri("/Home.xaml", UriKind.Relative));
        }

        private async System.Threading.Tasks.Task AuthenticateWithFacebook()
        {
            // Calls the Mobile Service available on Windows Azure and let the user login to the app using Facebook as the provider.
            while (App.MobileService.CurrentUser == null)
            {
                string message;
                try
                {
                    App.MobileService.CurrentUser = await App.MobileService.LoginAsync(MobileServiceAuthenticationProvider.Facebook);
                    //message = string.Format("You are now logged in - {0}", App.MobileService.CurrentUser.UserId);
                }
                catch (InvalidOperationException)
                {
                    message = "You must log in. Login Required";
                    MessageBox.Show(message);
                }

                
            }
        }

        private async System.Threading.Tasks.Task AuthenticateWithTwitter()
        {
            // Calls the Mobile Service available on Windows Azure and let the user login to the app using Twitter as the provider.
            while (App.MobileService.CurrentUser == null)
            {
                string message;
                try
                {
                    App.MobileService.CurrentUser = await App.MobileService.LoginAsync(MobileServiceAuthenticationProvider.Twitter);
                    //message = string.Format("You are now logged in - {0}", App.MobileService.CurrentUser.UserId);
                }
                catch (InvalidOperationException)
                {
                    message = "You must log in. Login Required";
                    MessageBox.Show(message);
                }

                
            }
        }
    }
}