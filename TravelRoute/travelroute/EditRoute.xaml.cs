using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using System.Device.Location;
using System.Windows.Shapes;
using System.Windows.Media;
using Microsoft.Phone.Maps.Controls;
using Microsoft.Phone.Maps.Toolkit;
using System.Windows.Media.Imaging;

namespace travelroute
{
    public partial class EditRoute : PhoneApplicationPage
    {
        private Geolocator geolocator = null;
        private Ellipse mapCircle = new Ellipse();

        private MapOverlay myLocationOverlay = new MapOverlay();
        private MapLayer myLocationLayer = new MapLayer();

        private MapLayer registerLayer = new MapLayer();

        private bool firstMapLoad = true;

        public EditRoute()
        {
            InitializeComponent();

            // Create a small circle to mark the current location.

            mapCircle.Fill = new SolidColorBrush(Colors.Blue);
            mapCircle.Height = 20;
            mapCircle.Width = 20;
            mapCircle.Opacity = 50;

            registerGrid.Visibility = System.Windows.Visibility.Collapsed;

            routeMap.Layers.Add(registerLayer);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            geolocator = new Geolocator();
            geolocator.DesiredAccuracy = PositionAccuracy.High;
            geolocator.MovementThreshold = 1; // The units are meters.

            geolocator.PositionChanged += geolocator_PositionChanged;


            myLocationOverlay.Content = mapCircle;
            myLocationOverlay.PositionOrigin = new Point(0.5, 0.5);
            mapCircle.Visibility = System.Windows.Visibility.Collapsed;

            myLocationLayer.Add(myLocationOverlay);
            routeMap.Layers.Add(myLocationLayer);
        }

        private void geolocator_PositionChanged(Geolocator sender, PositionChangedEventArgs args)
        {
            Dispatcher.BeginInvoke(() =>
            {
                double lat = args.Position.Coordinate.Latitude;
                double lon = args.Position.Coordinate.Longitude;

                GeoCoordinate gc = new GeoCoordinate(lat, lon);

                mapCircle.Visibility = System.Windows.Visibility.Visible;
                myLocationOverlay.GeoCoordinate = gc;

                if (firstMapLoad)
                {
                    routeMap.Center = gc;
                    routeMap.ZoomLevel = 18;

                    firstMapLoad = false;
                }
            });
        }

        private void addRegisterButton_Click(object sender, EventArgs e)
        {
            if (registerGrid.Visibility == System.Windows.Visibility.Collapsed)
            {
                registerGrid.Visibility = System.Windows.Visibility.Visible;
            }

            else
            {
                registerGrid.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void POIButton_Click(object sender, RoutedEventArgs e)
        {
            Image image = new Image();
            //Define the URI location of the image
            image.Source = new BitmapImage(new Uri("Assets/Icons/registerPOI.png", UriKind.Relative));
            image.Stretch = System.Windows.Media.Stretch.None;

            MapOverlay registerOverlay = new MapOverlay();

            registerOverlay.Content = image;
            registerOverlay.PositionOrigin = new Point(0.5, 0.9);
            registerOverlay.GeoCoordinate = myLocationOverlay.GeoCoordinate;

            registerLayer.Add(registerOverlay);

            NavigationService.Navigate(new Uri("/NewRegister.xaml", UriKind.Relative));
        }

        private void sleepButton_Click(object sender, RoutedEventArgs e)
        {
            Image image = new Image();
            //Define the URI location of the image
            image.Source = new BitmapImage(new Uri("Assets/Icons/registerSleep.png", UriKind.Relative));
            image.Stretch = System.Windows.Media.Stretch.None;

            MapOverlay registerOverlay = new MapOverlay();

            registerOverlay.Content = image;
            registerOverlay.PositionOrigin = new Point(0.5, 0.9);
            registerOverlay.GeoCoordinate = myLocationOverlay.GeoCoordinate;

            registerLayer.Add(registerOverlay);
        }

        private void restaurantButton_Click(object sender, RoutedEventArgs e)
        {
            Image image = new Image();
            //Define the URI location of the image
            image.Source = new BitmapImage(new Uri("Assets/Icons/registerEat.png", UriKind.Relative));
            image.Stretch = System.Windows.Media.Stretch.None;

            MapOverlay registerOverlay = new MapOverlay();

            registerOverlay.Content = image;
            registerOverlay.PositionOrigin = new Point(0.5, 0.9);
            registerOverlay.GeoCoordinate = myLocationOverlay.GeoCoordinate;

            registerLayer.Add(registerOverlay);
        }

        private void transportButton_Click(object sender, RoutedEventArgs e)
        {
            Image image = new Image();
            //Define the URI location of the image
            image.Source = new BitmapImage(new Uri("Assets/Icons/registerTransport.png", UriKind.Relative));
            image.Stretch = System.Windows.Media.Stretch.None;

            MapOverlay registerOverlay = new MapOverlay();

            registerOverlay.Content = image;
            registerOverlay.PositionOrigin = new Point(0.5, 0.9);
            registerOverlay.GeoCoordinate = myLocationOverlay.GeoCoordinate;

            registerLayer.Add(registerOverlay);
        }

        private void pictureButton_Click(object sender, RoutedEventArgs e)
        {
            Image image = new Image();
            //Define the URI location of the image
            image.Source = new BitmapImage(new Uri("Assets/Icons/registerPicture.png", UriKind.Relative));
            image.Stretch = System.Windows.Media.Stretch.None;

            MapOverlay registerOverlay = new MapOverlay();

            registerOverlay.Content = image;
            registerOverlay.PositionOrigin = new Point(0.5, 0.9);
            registerOverlay.GeoCoordinate = myLocationOverlay.GeoCoordinate;

            registerLayer.Add(registerOverlay);
        }

        private void commentButton_Click(object sender, RoutedEventArgs e)
        {
            Image image = new Image();
            //Define the URI location of the image
            image.Source = new BitmapImage(new Uri("Assets/Icons/registerComment.png", UriKind.Relative));
            image.Stretch = System.Windows.Media.Stretch.None;

            MapOverlay registerOverlay = new MapOverlay();

            registerOverlay.Content = image;
            registerOverlay.PositionOrigin = new Point(0.5, 0.9);
            registerOverlay.GeoCoordinate = myLocationOverlay.GeoCoordinate;

            registerLayer.Add(registerOverlay);
        }
    }
}