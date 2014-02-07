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

namespace travelroute
{
    public class Ruta
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "tipo")]
        public string Tipo { get; set; }

        [JsonProperty(PropertyName = "descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty(PropertyName = "tipoclima")]
        public string TipoClima { get; set; }

        [JsonProperty(PropertyName = "diasduracion")]
        public int DiasDuracion { get; set; }

        [JsonProperty(PropertyName = "nombre")]
        public string Nombre { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public string Tags { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }
    }

    //static class so it is available to every class on the project. This way different interfaces can interact
    //with the database hosted in Windows Azure
    public static class AzureDBM
    {
        

        // MobileServiceCollectionView implements ICollectionView (useful for databinding to lists) and 
        // is integrated with your Mobile Service to make it easy to bind your data to the ListView
        
        public static MobileServiceCollection<Ruta, Ruta> items;

        public static IMobileServiceTable<Ruta> rutaTable = App.MobileService.GetTable<Ruta>();

        //auxImage until we can host them on Azure
        public static BitmapImage auxImage = new BitmapImage(new Uri("Assets/rutaPisco.png", UriKind.Relative));

        public static async void InsertRuta(Ruta ruta)
        {
            // This code inserts a new Ruta into the database. When the operation completes
            // and Mobile Services has assigned an Id, the item is added to the Home Page.
            await rutaTable.InsertAsync(ruta);
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
