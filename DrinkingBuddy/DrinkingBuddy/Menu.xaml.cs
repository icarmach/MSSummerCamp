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
    public partial class Menu : PhoneApplicationPage
    {
        public static int[] arreglo = new int [] {0,0,0,0,0};

        public Menu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          NavigationService.Navigate(new Uri("/Tips.xaml", UriKind.Relative));
        }

        private void Cabeza_check_Checked(object sender, RoutedEventArgs e)
        {
            arreglo[0] = 1;
        }

        private void Estomago_check_Checked(object sender, RoutedEventArgs e)
        {
            arreglo[1] = 1;
        }

        private void Mareo_check_Checked(object sender, RoutedEventArgs e)
        {
            arreglo[2] = 1;
        }

        private void Vomito_check_Checked(object sender, RoutedEventArgs e)
        {
            arreglo[3] = 1;
        }

        private void Zombie_check_Checked(object sender, RoutedEventArgs e)
        {
            arreglo[4] = 1;
        }

        
        
    }
}