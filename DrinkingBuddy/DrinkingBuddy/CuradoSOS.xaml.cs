using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using System.IO.IsolatedStorage;

namespace DrinkingBuddy
{
    public partial class CuradoSOS : PhoneApplicationPage
    {
        string friendNameText = "";
        string friendNumberText = "";

        public CuradoSOS()
        {
            InitializeComponent();

            if (IsolatedStorageSettings.ApplicationSettings.Contains("friendName") && IsolatedStorageSettings.ApplicationSettings.Contains("friendNum"))
            {
                friendNameText = IsolatedStorageSettings.ApplicationSettings["friendName"] as string;
                friendNumberText = IsolatedStorageSettings.ApplicationSettings["friendNum"] as string;

                friendName.Text = friendNameText;
            }

            else
            {
                MessageBox.Show("no tienes amigo S.O.S, agrégalo en los ajustes");
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask phoneCallTask = new PhoneCallTask()
            {
                DisplayName = friendNameText,
                PhoneNumber = friendNumberText
            };

            phoneCallTask.Show();
        }
    }
}