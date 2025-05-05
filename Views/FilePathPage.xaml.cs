using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class FilePathPage : ContentPage
{
    // Iitalize
    public FilePathPage()
    {
        InitializeComponent();
    }
    
    private async void OnSaveFilePathsClicked(object sender, EventArgs e)
    {
        // Temp variables to hold filepath string
        string airPath = AirFilePathEntry.Text;
        string waterPath = WaterFilePathEntry.Text;
        string weatherPath = WeatherFilePathEntry.Text;
        
        // Checking which sensor and then setting its filepath appropriately 
        foreach (var sensor in AppData.Sensors)
        {
             if (sensor is AirQualitySensor)
                    sensor.FilePath = airPath;

             else if (sensor is WaterQualitySensor)
                    sensor.FilePath = waterPath;

             else if (sensor is WeatherQualitySensor)
                    sensor.FilePath = weatherPath;
        }

        // user feedback so they know
         await DisplayAlert("Success", "File paths saved for Firmware Update on all sensors.", "OK");
        await Navigation.PopAsync();
    }
}