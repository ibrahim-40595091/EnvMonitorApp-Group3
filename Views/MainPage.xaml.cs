using MauiApp1.ViewModels;
using MauiApp1.Models;  


namespace MauiApp1.Views
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
      
    private async void OnSensorButtonClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is Sensor sensor)
        {
            await DisplayAlert(
                "Sensor Information",
                $"Location: {sensor.Location}\nLatitude: {sensor.Latitude:F4}\nLongitude: {sensor.Longtitude:F4}",
                "OK");
        }
    }
    }

}
