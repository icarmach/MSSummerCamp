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
        
        string TipCabeza = "Toma un vaso de agua ";
        string TipEstomago = "Recuestate";
        string TipMareo = "Toma aguita de hiervas ";
        string TipVomito = "Sigue ";
        string TipZombie = "Adiós amigo ...";
        public Tips()
        {
            
            InitializeComponent();
            int [] arreglo2 = Menu.arreglo;

            //CABEZA
            if (arreglo2[0] == 1)
            {
                c_txtBox.Text = TipCabeza;
            }else
            {
                c_txtBox.Visibility = Visibility.Collapsed;
            }

            //ESTOMAGO
            if (arreglo2[1] == 1)
            {
                e_txtBox.Text = TipEstomago;
            }else
            {
                e_txtBox.Visibility = Visibility.Collapsed;
            }

            //MAREO
            if (arreglo2[2] == 1)
            {
                m_txtBox.Text = TipMareo;
            }else
            {
                m_txtBox.Visibility = Visibility.Collapsed;
            }

            //VOMITO
            if (arreglo2[3] == 1)
            {
                v_txtBox.Text = TipVomito;
            }else
            {
                v_txtBox.Visibility = Visibility.Collapsed;
            }

            //ZOMBIE
            if (arreglo2[4] == 1)
            {
                z_txtBox.Text = TipZombie;
            }else
            {
                z_txtBox.Visibility = Visibility.Collapsed;
            }
        }
    }
}