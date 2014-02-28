﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;
using System.IO;
using travelroute.DBClasses;
using System.Windows.Media;

namespace travelroute
{
    public partial class NewRegister : PhoneApplicationPage
    {
        // Using a stream reference to upload the image to blob storage.
        Stream imageStream = null;
        int appreciation = 0;

        public NewRegister()
        {
            InitializeComponent();
        }

        private void registerDescription_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Scrolls to the end of the ScrollViewer so the user can see what he is typing.
            registerDescriptionScrollViewer.ScrollToVerticalOffset(200);
        }

        private void registerImage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //PhotoChooserTask gives you access to the gallery on the phone (and optionally to the camera)
            //to let the user select or take a picture.
            PhotoChooserTask photo = new PhotoChooserTask();
            photo.ShowCamera = true;

            //Shows the gallery app
            photo.Show();

            //When the user selects a picture, he is taken back to the app and the photo.Completed event is triggered.
            photo.Completed += photo_Completed;
        }

        private void photo_Completed(object sender, PhotoResult e)
        {
            //If the user really selected a picture (didn't press back)
            if (e != null && e.ChosenPhoto != null)
            {
                //Get the picture selected and set it as the source to the routeImage
                BitmapImage image = new BitmapImage();
                image.SetSource(e.ChosenPhoto);
                registerImage.Source = image;

                imageStream = e.ChosenPhoto;
            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Creates the new Register and then it sends it to Azure so we can store the route data.
            var register = new Register { Appreciation = appreciation, CreatedByCurrentUser = true, Description = registerDescription.Text, Expenses = Convert.ToInt32(registerExpenses.Text), Type = AzureDBM.selectedRegisterType, Latitude = AzureDBM.selectedRegisterLat, Longitude = AzureDBM.selectedRegisterLon, Name = registerName.Text, RouteId = AzureDBM.selectedRoute.Id };
            AzureDBM.InsertRegister(register);

            NavigationService.Navigate(new Uri("/EditRoute.xaml", UriKind.Relative));
        }

        private void muyMalaImage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            appreciation = 1;
            muyMalaImage.Source = new BitmapImage(new Uri("/Assets/rutaPisco.png", UriKind.Relative));
            malaImage.Source = new BitmapImage(new Uri("/Assets/rutaPisco.png", UriKind.Relative));
            regularImage.Source = new BitmapImage(new Uri("/Assets/rutaPisco.png", UriKind.Relative));
            buenaImage.Source = new BitmapImage(new Uri("/Assets/rutaPisco.png", UriKind.Relative));
            muyBuenaImage.Source = new BitmapImage(new Uri("/Assets/rutaPisco.png", UriKind.Relative));
        }

        private void malaImage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void regularImage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void buenaImage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void muyBuenaImage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        
    }
}