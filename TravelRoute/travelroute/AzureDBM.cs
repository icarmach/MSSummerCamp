﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.MobileServices;
using travelroute.Resources;
using travelroute.DBClasses;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Controls;
using System.Windows;
using Microsoft.Phone.Tasks;
using System.IO;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;

namespace travelroute
{
    //static class so it is available to every class on the project. This way different interfaces can interact
    //with the database hosted in Windows Azure
    public static class AzureDBM
    {
        // MobileServiceCollectionView implements ICollectionView (useful for databinding to lists) and 
        // is integrated with your Mobile Service to make it easy to bind your data to the ListView
        
        public static MobileServiceCollection<Route, Route> routeItems;
        public static IMobileServiceTable<Route> routeTable = App.MobileService.GetTable<Route>();

        public static MobileServiceCollection<User, User> userItems;
        public static IMobileServiceTable<User> userTable = App.MobileService.GetTable<User>();

        //temp variables
        public static Route selectedRoute;

        public static async System.Threading.Tasks.Task AuthenticateWithFacebook()
        {
            // Calls the Mobile Service available on Windows Azure and let the user login to the app using Facebook as the provider.
            while (App.MobileService.CurrentUser == null)
            {
                string message;
                try
                {
                    App.MobileService.CurrentUser = await App.MobileService.LoginAsync(MobileServiceAuthenticationProvider.Facebook);
                    AzureDBM.LoadUserData();
                }
                catch (InvalidOperationException)
                {
                    message = "Ha ocurrido un error al iniciar sesión, por favor inténtalo nuevamente";
                    MessageBox.Show(message);

                    break;
                }


            }
        }

        public static async System.Threading.Tasks.Task AuthenticateWithTwitter()
        {
            // Calls the Mobile Service available on Windows Azure and let the user login to the app using Twitter as the provider.
            while (App.MobileService.CurrentUser == null)
            {
                string message;
                try
                {
                    //App.MobileService.CurrentUser = await App.MobileService.LoginAsync(MobileServiceAuthenticationProvider.Twitter);
                    //message = string.Format("You are now logged in - {0}", App.MobileService.CurrentUser.UserId);

                    message = "Aun tenemos problemas con Twitter, por favor intenta iniciar sesión con Facebook";
                    MessageBox.Show(message);

                    break;
                }
                catch (InvalidOperationException)
                {
                    message = "Ha ocurrido un error al iniciar sesión, por favor inténtalo nuevamente";
                    MessageBox.Show(message);

                    break;
                }


            }
        }

        public static async void InsertRoute(Route route, Stream imageStream)
        {
            //The user didn't added a picture to the route
            if (imageStream == null)
            {
                // This code inserts a new Ruta into the database. When the operation completes
                // and Mobile Services has assigned an Id, the item is added to the Home Page.
                await routeTable.InsertAsync(route);
                //items.Add(ruta);
            }

            else
            {
                imageStream.Seek(0, SeekOrigin.Begin);
                string errorString = string.Empty;

                if (imageStream != null)
                {
                    // Set blob properties of TodoItem.
                    route.ContainerName = "routecoverimages";
                    route.ResourceName = Guid.NewGuid().ToString() + ".jpg";
                }

                // Send the item to be inserted. When blob properties are set this
                // generates an SAS in the response.
                await routeTable.InsertAsync(route);

                // If we have a returned SAS, then upload the blob.
                if (!string.IsNullOrEmpty(route.SasQueryString))
                {
                    // Get the URI generated that contains the SAS 
                    // and extract the storage credentials.
                    StorageCredentials cred = new StorageCredentials(route.SasQueryString);
                    var imageUri = new Uri(route.RoutePicture);

                    // Instantiate a Blob store container based on the info in the returned item.
                    CloudBlobContainer container = new CloudBlobContainer(
                        new Uri(string.Format("https://{0}/{1}",
                            imageUri.Host, route.ContainerName)), cred);

                    // Upload the new image as a BLOB from the stream.
                    CloudBlockBlob blobFromSASCredential =
                        container.GetBlockBlobReference(route.ResourceName);
                    await blobFromSASCredential.UploadFromStreamAsync(imageStream);

                    // When you request an SAS at the container-level instead of the blob-level,
                    // you are able to upload multiple streams using the same container credentials.

                    imageStream = null;
                }

                // Add the new item to the collection.
                routeItems.Add(route);
            }
        }

        public static async void SignOut()
        {
            //If there is an authenticated user then logout
            if (App.MobileService.CurrentUser != null && App.MobileService.CurrentUser.UserId != null)
            {
                App.MobileService.Logout();
                await new WebBrowser().ClearCookiesAsync();
                //await new WebBrowser().ClearInternetCacheAsync();
            }
        }

        public static async void LoadUserData()
        {
            //Loads user data
            try
            {
                AzureDBM.userItems = await AzureDBM.userTable
                    .Where(usuario => usuario.FacebookId == App.MobileService.CurrentUser.UserId)
                    .ToCollectionAsync();
            }
            catch (MobileServiceInvalidOperationException e)
            {
                MessageBox.Show(e.Message, "Error loading user data", MessageBoxButton.OK);
            }

        }
    }
}
