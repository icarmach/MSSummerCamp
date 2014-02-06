using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace travelroute
{
    public partial class Home : PhoneApplicationPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private void HomePanorama_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count < 1)
            {
                return;
            }

            if (!(e.AddedItems[0] is PanoramaItem))
            {
                return;
            }

            PanoramaItem selectedItem = (PanoramaItem)e.AddedItems[0];

            string tag = (string)selectedItem.Tag;
            
            if (tag.Equals("populares"))
            {
                if (this.ApplicationBar.Buttons.Count == 4)
                {
                    this.ApplicationBar.Buttons.RemoveAt(0);
                    this.ApplicationBar.Buttons.RemoveAt(0);
                    this.ApplicationBar.Buttons.RemoveAt(0);

                    ApplicationBarIconButton button1 = new ApplicationBarIconButton();
                    button1.IconUri = new Uri("Assets/Icons/copy.png", UriKind.Relative);
                    button1.Text = "copiar";
                    this.ApplicationBar.Buttons.Insert(0, button1);
                    //button1.Click += new EventHandler(button1_Click);
                }
            }

            else if (tag.Equals("rutas"))
            {
                this.ApplicationBar.Buttons.RemoveAt(0);

                ApplicationBarIconButton button1 = new ApplicationBarIconButton();
                button1.IconUri = new Uri("Assets/Icons/add.png", UriKind.Relative);
                button1.Text = "agregar";
                this.ApplicationBar.Buttons.Insert(0,button1);
                //button1.Click += new EventHandler(button1_Click);

                ApplicationBarIconButton button2 = new ApplicationBarIconButton();
                button2.IconUri = new Uri("Assets/Icons/edit.png", UriKind.Relative);
                button2.Text = "editar";
                this.ApplicationBar.Buttons.Insert(1, button2);
                //button2.Click += new EventHandler(button2_Click);

                ApplicationBarIconButton button3 = new ApplicationBarIconButton();
                button3.IconUri = new Uri("Assets/Icons/delete.png", UriKind.Relative);
                button3.Text = "eliminar";
                this.ApplicationBar.Buttons.Insert(2, button3);
                //button3.Click += new EventHandler(button3_Click);
            }

            else if (tag.Equals("buscar"))
            {
                if (this.ApplicationBar.Buttons.Count == 4)
                {
                    this.ApplicationBar.Buttons.RemoveAt(0);
                    this.ApplicationBar.Buttons.RemoveAt(0);
                    this.ApplicationBar.Buttons.RemoveAt(0);

                    ApplicationBarIconButton button1 = new ApplicationBarIconButton();
                    button1.IconUri = new Uri("Assets/Icons/copy.png", UriKind.Relative);
                    button1.Text = "copiar";
                    this.ApplicationBar.Buttons.Insert(0, button1);
                    //button1.Click += new EventHandler(button1_Click);
                }
                
            }

            else if (tag.Equals("perfil"))
            {

            }

            else if (tag.Equals("tienda"))
            {

            }
           
        }
    }
}