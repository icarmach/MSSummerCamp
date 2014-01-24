using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace DrinkingBuddy
{
    public partial class Curado : PhoneApplicationPage
    {
        public Curado()
        {
            InitializeComponent();
        }

        private void happyImage_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CuradoTest.xaml", UriKind.Relative));
        }

        private void curadoImage_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CuradoTips.xaml", UriKind.Relative));
        }

        private void zombieImage_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CuradoSOS.xaml", UriKind.Relative));
        }
    }
}