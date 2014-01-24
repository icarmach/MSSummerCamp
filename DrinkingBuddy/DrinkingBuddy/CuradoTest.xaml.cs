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
    public partial class Page2 : PhoneApplicationPage
    {
        int counter = 0;
        bool canGoBack = false;
        public Page2()
        {
            InitializeComponent();

            getRandomNumbers();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            if(counter < 3)
            {
                //bien
                if(Convert.ToInt32(Num1.Text) + Convert.ToInt32(Num2.Text) == Convert.ToInt32(Result.Text))
                {
                    Result.Text = "";
                    getRandomNumbers();
                }

                //mal
                else
                {
                    NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                }
            }

            else
            {
                //bien, consejo
                NavigationService.Navigate(new Uri("/Curado.xaml", UriKind.Relative));
            }
        }

        public void getRandomNumbers()
        {
            System.Random r = new Random();
            Num1.Text = r.Next(1,99).ToString();
            Num2.Text = r.Next(1,99).ToString();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            if(!canGoBack)
            {
                base.OnBackKeyPress(e);
                e.Cancel = true;
                canGoBack = true;

                if (IsolatedStorageSettings.ApplicationSettings.Contains("userName"))
                {
                    String s = IsolatedStorageSettings.ApplicationSettings["userName"] as string;

                    MessageBox.Show("¿Qué pasa " + s + ", muy difícil?");
                }

                MessageBox.Show("¿Qué pasa, muy difícil?");
            }

            else if(canGoBack)
            {
                base.OnBackKeyPress(e);
                e.Cancel = false;
            }
            
        }
    }
}