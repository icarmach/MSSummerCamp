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

    public partial class Tips : PhoneApplicationPage
    {
        
        public Tips()
        {
            
            InitializeComponent();
            int [] arreglo2 = encanadoMenu.arreglo;

            //CABEZA
            if (arreglo2[0] == 0)
            {
                tipCabeza.Visibility = Visibility.Collapsed;
            }

            //ESTOMAGO
            if (arreglo2[1] == 0)
            {
                tipGuata.Visibility = Visibility.Collapsed;
            }

            //Cacana
            if (arreglo2[2] == 0)
            {
                tipCacana.Visibility = System.Windows.Visibility.Collapsed;
            }

            //Mareo
            if (arreglo2[3] == 0)
            {
                tipMareo.Visibility = System.Windows.Visibility.Collapsed;
            }

            //witre
            if (arreglo2[4] == 0)
            {
                tipWitre.Visibility = System.Windows.Visibility.Collapsed;
            }

            //ZOMBIE
            if (arreglo2[5] == 0)
            {
                tipZombie.Visibility = System.Windows.Visibility.Collapsed;
            }
        }
    }
}