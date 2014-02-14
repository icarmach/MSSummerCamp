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
        private void facebookLoginButton_Click(object sender, RoutedEventArgs e)
        {
            //Put some fairy dust in here
        }

        private async void twitterLoginButton_Click(object sender, RoutedEventArgs e)
        {
            //Awaits for the twitter login and the redirects the user to the Home layout
            await AzureDBM.AuthenticateWithTwitter();
            NavigationService.Navigate(new Uri("/Home.xaml", UriKind.Relative));
        }

        private async void SecondSecretFacebookLogin(object sender, Facebook.Client.Controls.SessionStateChangedEventArgs e)
        {

            //pero acá estas poniendo en la base de datos, datos que de donde salen?? ...

            
            //AzureDBM.userCity = loginButton.CurrentUser.Location.ToString();
            //AzureDBM.userProfilePicture = loginButton.CurrentUser.ProfilePictureUrl.ToString();

            //Awaits for the facebook login and the redirects the user to the Home layout
            await AzureDBM.AuthenticateWithFacebook();
            AzureDBM.userName = loginButton.CurrentUser.Name;
            NavigationService.Navigate(new Uri("/Home.xaml", UriKind.Relative));
        }

        
    }
}