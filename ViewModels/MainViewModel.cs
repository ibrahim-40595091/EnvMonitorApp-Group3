using System.Collections.ObjectModel;
using MauiApp1.Models; 

namespace MauiApp1.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Sensor> Sensors { get; set; }

        public MainViewModel()
        {
            var airSensor = new AirQualitySensor(51.5074, -0.1278);
            var waterSensor = new WaterQualitySensor(37.7749, -122.4194);
            var weatherSensor = new WeatherQualitySensor(48.8566, 2.3522); 

            airSensor.AddReading(40.5f, 15.2f, 22.1f, 30.0f);
            airSensor.AddReading(38.7f, 14.5f, 24.6f, 29.1f);

            waterSensor.AddReading(2.5f, 0.7f, 1.2f, 10.0f);
            waterSensor.AddReading(2.8f, 0.5f, 1.5f, 8.7f);

            weatherSensor.AddReading(18.5f, 65.0f, 12.3f, 270.0f);
            weatherSensor.AddReading(20.1f, 60.0f, 14.0f, 290.0f);

            airSensor.MaintenanceDate = DateTime.Now.AddDays(30);
            weatherSensor.MaintenanceDate = DateTime.Now.AddDays(45);
            // waterSensor.MaintenanceDate = null; // not yet scheduled


            Sensors = new ObservableCollection<Sensor>
            {
                airSensor,
                waterSensor,
                weatherSensor
            };
        }
    }
}
