using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class MaintenancePage : ContentPage
{
    public MaintenancePage()
    {
        InitializeComponent();
    
    }

      private async void OnApplyClicked(object sender, EventArgs e)
    {
        foreach (var sensor in AppData.Sensors)  
        {
            if (sensor is AirQualitySensor)
                    sensor.MaintenanceDate = AirDatePicker.Date;
            else if (sensor is WaterQualitySensor)
                    sensor.MaintenanceDate = WaterDatePicker.Date;
            else if (sensor is WeatherQualitySensor)
                      sensor.MaintenanceDate = WeatherDatePicker.Date;
        }

        await DisplayAlert("Success", "Maintenance dates updated!", "OK");
        await Navigation.PopAsync(); // go back to HomePage
    }


}