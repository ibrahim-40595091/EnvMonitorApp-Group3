using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class MaintenancePage : ContentPage
{
    public MaintenancePage()
    {
        InitializeComponent();
    
    }

    // perfomr the action when the button is clicked 
      private async void OnApplyClicked(object sender, EventArgs e)
    {
        // goes through the sensors in App.Data 
        foreach (var sensor in AppData.Sensors)  
        {
            // checks to see which sensor and applies filepath to appropriate sensor
            if (sensor is AirQualitySensor)
                    sensor.MaintenanceDate = AirDatePicker.Date;
            else if (sensor is WaterQualitySensor)
                    sensor.MaintenanceDate = WaterDatePicker.Date;
            else if (sensor is WeatherQualitySensor)
                      sensor.MaintenanceDate = WeatherDatePicker.Date;
        }

        // user feed back
        await DisplayAlert("Success", "Maintenance dates updated!", "OK");
        await Navigation.PopAsync(); // go back to HomePage
    }


}