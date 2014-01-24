using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace DrinkingBuddy
{
    public partial class Setup2 : PhoneApplicationPage
    {
        public Setup2()
        {
            InitializeComponent();
            
            LoadSettings();
            
        }

        public void LoadSettings()
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains("userName"))
            {
                userName.Text = IsolatedStorageSettings.ApplicationSettings["userName"] as string;
            }

            if (IsolatedStorageSettings.ApplicationSettings.Contains("friendName"))
            {
                friendName.Text = IsolatedStorageSettings.ApplicationSettings["friendName"] as string;
            }

            if (IsolatedStorageSettings.ApplicationSettings.Contains("friendNum"))
            {
                friendNumber.Text = IsolatedStorageSettings.ApplicationSettings["friendNum"] as string;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

            if (!settings.Contains("userName"))
            {
                settings.Add("userName", userName.Text);
            }
            else
            {
                settings["userName"] = userName.Text;
            }

            if (!settings.Contains("friendName"))
            {
                settings.Add("friendName", friendName.Text);
            }
            else
            {
                settings["friendName"] = friendName.Text;
            }

            if (!settings.Contains("friendNum"))
            {
                settings.Add("friendNum", friendNumber.Text);
            }
            else
            {
                settings["friendNum"] = friendNumber.Text;
            }

            settings["settingsDone"] = "yes";

            settings.Save();

            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void friendNumber_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            
        }
    }
}