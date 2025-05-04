using System.Collections.ObjectModel;
using MauiApp1.Models;  // Replace with your actual namespace

namespace MauiApp1.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Sensor> Sensors { get; set; }

        public MainViewModel()
        {
            // 1. Create sensors
            var airSensor = new AirQualitySensor(51.5074, -0.1278); // London
            var waterSensor = new WaterQualitySensor(37.7749, -122.4194); // San Francisco
            var weatherSensor = new WeatherQualitySensor(48.8566, 2.3522); // Paris

            // 2. Add readings to AirQualitySensor
            airSensor.AddReading(40.5f, 15.2f, 22.1f, 30.0f);
            airSensor.AddReading(38.7f, 14.5f, 24.6f, 29.1f);

            // 3. Add readings to WaterQualitySensor
            waterSensor.AddReading(2.5f, 0.7f, 1.2f, 10.0f);
            waterSensor.AddReading(2.8f, 0.5f, 1.5f, 8.7f);

            // 4. Add readings to WeatherQualitySensor
            weatherSensor.AddReading(18.5f, 65.0f, 12.3f, 270.0f);
            weatherSensor.AddReading(20.1f, 60.0f, 14.0f, 290.0f);

            // 5. Optionally set maintenance dates
            airSensor.MaintenanceDate = DateTime.Now.AddDays(30);
            weatherSensor.MaintenanceDate = DateTime.Now.AddDays(45);
            // waterSensor.MaintenanceDate = null; // not yet scheduled

            // 6. Add sensors to collection
            Sensors = new ObservableCollection<Sensor>
            {
                airSensor,
                waterSensor,
                weatherSensor,


            };
        }
    }
}
