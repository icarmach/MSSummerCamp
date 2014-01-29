using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BlendTutorial.Resources;

namespace BlendTutorial
{
    public partial class MainPage : PhoneApplicationPage
    {
        int resAux = 0;
        bool borrar = true;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
            resumenOperaciones.Text = "";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (resAux == 0 && resultado.Text.Equals("0"))
            {
                buttonCE_Click(sender, e);
            }

            if(!borrar)
            {
                resultado.Text += button1.Content.ToString();
            }

            else
            {
                borrar = false;
                resultado.Text = button1.Content.ToString();
            }
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (resAux == 0 && resultado.Text.Equals("0"))
            {
                buttonCE_Click(sender, e);
            }

            if (!borrar)
            {
                resultado.Text += button0.Content.ToString();
            }

            else
            {
                resultado.Text = button0.Content.ToString();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (resAux == 0 && resultado.Text.Equals("0"))
            {
                buttonCE_Click(sender, e);
            }

            if (!borrar)
            {
                resultado.Text += button2.Content.ToString();
            }

            else
            {
                borrar = false;
                resultado.Text = button2.Content.ToString();
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (resAux == 0 && resultado.Text.Equals("0"))
            {
                buttonCE_Click(sender, e);
            }

            if (!borrar)
            {
                resultado.Text += button3.Content.ToString();
            }

            else
            {
                borrar = false;
                resultado.Text = button3.Content.ToString();
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (resAux == 0 && resultado.Text.Equals("0"))
            {
                buttonCE_Click(sender, e);
            }

            if (!borrar)
            {
                resultado.Text += button4.Content.ToString();
            }

            else
            {
                borrar = false;
                resultado.Text = button4.Content.ToString();
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (resAux == 0 && resultado.Text.Equals("0"))
            {
                buttonCE_Click(sender, e);
            }

            if (!borrar)
            {
                resultado.Text += button5.Content.ToString();
            }

            else
            {
                borrar = false;
                resultado.Text = button5.Content.ToString();
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (resAux == 0 && resultado.Text.Equals("0"))
            {
                buttonCE_Click(sender, e);
            }

            if (!borrar)
            {
                resultado.Text += button6.Content.ToString();
            }

            else
            {
                borrar = false;
                resultado.Text = button6.Content.ToString();
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (resAux == 0 && resultado.Text.Equals("0"))
            {
                buttonCE_Click(sender, e);
            }

            if (!borrar)
            {
                resultado.Text += button7.Content.ToString();
            }

            else
            {
                borrar = false;
                resultado.Text = button7.Content.ToString();
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (resAux == 0 && resultado.Text.Equals("0"))
            {
                buttonCE_Click(sender, e);
            }

            if (!borrar)
            {
                resultado.Text += button8.Content.ToString();
            }

            else
            {
                borrar = false;
                resultado.Text = button8.Content.ToString();
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (resAux == 0 && resultado.Text.Equals("0"))
            {
                buttonCE_Click(sender, e);
            }

            if (!borrar)
            {
                resultado.Text += button9.Content.ToString();
            }

            else
            {
                borrar = false;
                resultado.Text = button9.Content.ToString();
            }
        }

        private void buttonIgual_Click(object sender, RoutedEventArgs e)
        {
            if (!resultado.Text.Equals("0"))
            {
                resumenOperaciones.Text += resultado.Text;
                resultado.Text = (resAux + Convert.ToInt32(resultado.Text)).ToString();
                resAux = Convert.ToInt32(resultado.Text);
                borrar = true;
                resAux = 0;
            }
        }

        private void buttonSum_Click(object sender, RoutedEventArgs e)
        {
            if (!resultado.Text.Equals("0"))
            {
                resumenOperaciones.Text += resultado.Text + " + ";
                resultado.Text = (resAux + Convert.ToInt32(resultado.Text)).ToString();
                resAux = Convert.ToInt32(resultado.Text);
                borrar = true;
            }
        }

        private void buttonRest_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void buttonMult_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button9Div_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonBorrar_Click(object sender, RoutedEventArgs e)
        {
            resultado.Text = resultado.Text.Substring(0, resultado.Text.Count()-1);

            if(resultado.Text.Count() == 0)
            {
                resultado.Text = "0";
                borrar = true;
            }
        }

        private void buttonMM_Click(object sender, RoutedEventArgs e)
        {
            if (resultado.Text.Substring(0, 1).Equals("-"))
            {
                resultado.Text = resultado.Text.Substring(1);
            }

            else if(!resultado.Text.Equals("0"))
            {
                resultado.Text = "-" + resultado.Text;
            }

            
        }

        private void buttonCE_Click(object sender, RoutedEventArgs e)
        {
            resultado.Text = "0";
            borrar = true;
            resAux = 0;
            resumenOperaciones.Text = "";
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            resultado.Text = "0";
            borrar = true;
        }


        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}