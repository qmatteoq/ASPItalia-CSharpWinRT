using System;
using System.Windows;


namespace GeolocationWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void OnGetPosition(object sender, RoutedEventArgs e)
        {
            Windows.Devices.Geolocation.Geolocator geolocator = new();
            var result = await geolocator.GetGeopositionAsync();
            txtLatitude.Text = result.Coordinate.Point.Position.Latitude.ToString();
            txtLongitude.Text = result.Coordinate.Point.Position.Longitude.ToString();
        }
    }
}
