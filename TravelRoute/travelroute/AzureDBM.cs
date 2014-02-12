using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.MobileServices;
using travelroute.Resources;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Controls;
using System.Windows;

namespace travelroute
{
    public class Route
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty(PropertyName = "originalRouteId")]
        public string OriginalRouteId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "desciption")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "duration")]
        public int Duration { get; set; }

        [JsonProperty(PropertyName = "routePicture")]
        public string RoutePicture { get; set; }

        [JsonProperty(PropertyName = "copiedNumber")]
        public int CopiedNumber { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "isShared")]
        public bool IsShared { get; set; }

        [JsonProperty(PropertyName = "isPopular")]
        public bool IsPopular { get; set; }

        [JsonProperty(PropertyName = "place")]
        public string Place { get; set; }
    }

    //static class so it is available to every class on the project. This way different interfaces can interact
    //with the database hosted in Windows Azure
    public static class AzureDBM
    {
        

        // MobileServiceCollectionView implements ICollectionView (useful for databinding to lists) and 
        // is integrated with your Mobile Service to make it easy to bind your data to the ListView
        
        public static MobileServiceCollection<Route, Route> routeItems;

        public static IMobileServiceTable<Route> routeTable = App.MobileService.GetTable<Route>();

        //auxImage until we can host them on Azure
        public static BitmapImage auxImage = new BitmapImage(new Uri("Assets/rutaPisco.png", UriKind.Relative));

        public static async System.Threading.Tasks.Task AuthenticateWithFacebook()
        {
            // Calls the Mobile Service available on Windows Azure and let the user login to the app using Facebook as the provider.
            while (App.MobileService.CurrentUser == null)
            {
                string message;
                try
                {
                    App.MobileService.CurrentUser = await App.MobileService.LoginAsync(MobileServiceAuthenticationProvider.Facebook);
                    //message = string.Format("You are now logged in - {0}", App.MobileService.CurrentUser.UserId);
                }
                catch (InvalidOperationException)
                {
                    message = "You must log in. Login Required";
                    MessageBox.Show(message);
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
                    App.MobileService.CurrentUser = await App.MobileService.LoginAsync(MobileServiceAuthenticationProvider.Twitter);
                    //message = string.Format("You are now logged in - {0}", App.MobileService.CurrentUser.UserId);
                }
                catch (InvalidOperationException)
                {
                    message = "You must log in. Login Required";
                    MessageBox.Show(message);
                }


            }
        }

        public static async void InsertRoute(Route ruta)
        {
            // This code inserts a new Ruta into the database. When the operation completes
            // and Mobile Services has assigned an Id, the item is added to the Home Page.
            await routeTable.InsertAsync(ruta);
            //items.Add(ruta);
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
    }
}
