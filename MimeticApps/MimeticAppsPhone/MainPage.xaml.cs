using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace MimeticAppsPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private async void memberText1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var uri = new Uri("mailto:CatalinaL@summercampchile.com");
            await Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private async void memberText2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var uri = new Uri("mailto:MarioA@summercampchile.com");
            await Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private async void memberText3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var uri = new Uri("mailto:CamilaO@summercampchile.com");
            await Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private async void memberText4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var uri = new Uri("mailto:IgnacioC@summercampchile.com");
            await Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private async void memberText5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var uri = new Uri("mailto:CarlosC@summercampchile.com");
            await Windows.System.Launcher.LaunchUriAsync(uri);
        }

        
    }
}