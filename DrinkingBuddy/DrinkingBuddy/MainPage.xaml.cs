using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DrinkingBuddy.Resources;
using System.IO.IsolatedStorage;

namespace DrinkingBuddy
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            IsolatedStorageSettings tips = IsolatedStorageSettings.ApplicationSettings;

            if (!tips.Contains("tip1"))
            {
                tips.Add("tip1", "Este es el tip 1");
            }
            else
            {
                tips["tip1"] = "Tip 1";
            }

            if (!tips.Contains("tip2"))
            {
                tips.Add("tip2", "Este es el tip 2");
            }
            else
            {
                tips["tip2"] = "Tip 2";
            }


            if (!IsolatedStorageSettings.ApplicationSettings.Contains("settingsDone"))
            {
                NavigationService.Navigate(new Uri("/Setup2.xaml", UriKind.Relative));
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Curado.xaml", UriKind.Relative));
        }
        private void Settings_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Setup2.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/encanadoMenu.xaml", UriKind.Relative));
        }

        // Back Button pressed: notify MainPage so it can exit application
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            base.OnBackKeyPress(e);
            if (NavigationService.CanGoBack)
            {
                while (NavigationService.RemoveBackEntry() != null)
                {
                    NavigationService.RemoveBackEntry();
                }
            }
        }
    }
}