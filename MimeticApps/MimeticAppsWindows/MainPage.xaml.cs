using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MimeticAppsWindows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void member1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Catalina));
        }

        private void member2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ignacio));
        }

        private void member3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Carlos));
        }

        private void member4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Mario));
        }

        private void member5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Camila));
        }

        private void member6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MimeticApps));
        }

        private void portfolio1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(drinkingbuddy));
        }

        private void portfolio2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TravelRoute));
        }

        private void portfolio3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(WhatsForLunch));
        }

        private void portfolio4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EmergencyChat));
        }

    }
}
