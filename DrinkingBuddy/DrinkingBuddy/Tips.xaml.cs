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
            
        }
    }
}