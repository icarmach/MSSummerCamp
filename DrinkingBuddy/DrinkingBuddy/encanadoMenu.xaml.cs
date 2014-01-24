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
    public partial class encanadoMenu : PhoneApplicationPage
    {
        public static int[] arreglo = new int[] { 0, 0, 0, 0, 0 };

        public encanadoMenu()
        {
            InitializeComponent();
            CabezaOn_im.Visibility = Visibility.Collapsed;
            GuataOn_img.Visibility = Visibility.Collapsed;
            CacaOn_img.Visibility = Visibility.Collapsed;
            MareOn_img.Visibility = Visibility.Collapsed;
            witreoOn_img.Visibility = Visibility.Collapsed;
            ZombieOn_img.Visibility = Visibility.Collapsed;
        }

        private void CabezaOn_im_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CabezaOn_im.Visibility = Visibility.Collapsed;
            CabezaOff_img.Visibility = Visibility.Visible;
            arreglo[0] = 0;
        }

        private void GuataOn_img_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            GuataOn_img.Visibility = Visibility.Collapsed;
            GuataOff_img.Visibility = Visibility.Visible;
            arreglo[1] = 0;
        }

        private void CacaOn_img_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CacaOn_img.Visibility = Visibility.Collapsed;
            cacaOff_img.Visibility = Visibility.Visible;
            arreglo[2] = 0;

        }

        private void MareOn_img_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MareOn_img.Visibility = Visibility.Collapsed;
            MareOff_img.Visibility = Visibility.Visible;
            arreglo[3] = 0;
        }

        private void witreoOn_img_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            witreoOn_img.Visibility = Visibility.Collapsed;
            WitreoOff_img.Visibility = Visibility.Visible;
            arreglo[4] = 0;
        }

        private void ZombieOn_img_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ZombieOn_img.Visibility = Visibility.Collapsed;
            ZombieOff_img.Visibility = Visibility.Visible;
            arreglo[5] = 0;
        }

        private void CabezaOff_img_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CabezaOff_img.Visibility = Visibility.Collapsed;
            CabezaOn_im.Visibility = Visibility.Visible;
            arreglo[0] = 1;
        }

        private void GuataOff_img_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            GuataOff_img.Visibility = Visibility.Collapsed;
            GuataOn_img.Visibility = Visibility.Visible;
            arreglo[1] = 1;
        }

        private void cacaOff_img_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            cacaOff_img.Visibility = Visibility.Collapsed;
            CacaOn_img.Visibility = Visibility.Visible;
            arreglo[2] = 1;
        }

        private void MareOff_img_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MareOff_img.Visibility = Visibility.Collapsed;
            MareOn_img.Visibility = Visibility.Visible;
            arreglo[3] = 1;
        }


        private void WitreoOff_img_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            WitreoOff_img.Visibility = Visibility.Collapsed;
            witreoOn_img.Visibility = Visibility.Visible;
            arreglo[4] = 1;
        }

        private void ZombieOff_img_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ZombieOff_img.Visibility = Visibility.Collapsed;
            ZombieOn_img.Visibility = Visibility.Visible;
            arreglo[5] = 1;
        }

        //Metodo boton enviar
        //NavigationService.Navigate(new Uri("/Tips.xaml", UriKind.Relative));
    }
}