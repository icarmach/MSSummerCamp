using Facebook.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using travelroute.DBClasses;
using travelroute.Resources;
using travelroute.ViewModels;

namespace travelroute
{
    public class facebookClass
    {
        private FacebookSession session;
        public static async void PublishStory(string descriptionPost, string picturePost)
        {

            FacebookSession session;
            string message = String.Empty;


            try
            {
                session = await App.FacebookSessionClient.LoginAsync("publish_stream");
                App.AccessToken = session.AccessToken;

            }
            catch (InvalidOperationException e)
            {
                message = "Login failed! Exception details: " + e.Message;
                MessageBox.Show(message);
                return;
            }

            var facebookClient = new Facebook.FacebookClient(App.AccessToken);

            var postParams = new
            {
                name = "Travel route",
                caption = "Estoy usando travel route",
                description = "Quiza hola",
                link = "https://www.facebook.com/TravelRouteSummerCamp",
                picture = "http://www.webmasternerd.com/wp-content/uploads/2013/08/2.jpg"
            };

            try
            {
                dynamic fbPostTaskResult = await facebookClient.PostTaskAsync("/me/feed", postParams);
                var result = (IDictionary<string, object>)fbPostTaskResult;


                MessageBox.Show("Usted ha publicado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception during post: " + ex.Message, "Error", MessageBoxButton.OK);
            }
        }


    }
}
