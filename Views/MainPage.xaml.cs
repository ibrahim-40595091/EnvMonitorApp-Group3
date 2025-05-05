using MauiApp1.ViewModels;
using MauiApp1.Models;  


namespace MauiApp1.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            
            BindingContext = new MainViewModel();
        }
      
    // When sensor button is clicked perform the action 
    private async void OnSensorButtonClicked(object sender, EventArgs e)
    {
        // Checks if the object triggered was a button and also checks if it is a sensor if it is a sensor then it assigns itself the variable
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
