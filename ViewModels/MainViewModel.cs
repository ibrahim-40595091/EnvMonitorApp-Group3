using System.Collections.ObjectModel;
using MauiApp1.Models;  

namespace MauiApp1.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Sensor> Sensors { get; set; }

        public MainViewModel()
        {
            // 1. Create sensors
            
            var airSensor = new AirQualitySensor(55.9448, -3.1878); 
            var waterSensor = new WaterQualitySensor(55.8611, -3.2539); 
            var weatherSensor = new WeatherQualitySensor(55.0088, -3.5856); 

          
            // 10 readings for AirQualitySensor 
            airSensor.AddReading(26.4f, 1.6f, 5.1f, 8.3f);
            airSensor.AddReading(22.6f, 1.3f, 5.1f, 7.9f);
            airSensor.AddReading(14.5f, 1.5f, 5.8f, 8.5f);
            airSensor.AddReading(18.0f, 1.3f, 5.9f, 9.9f);
            airSensor.AddReading(12.2f, 1.3f, 6.1f, 10.7f);
            airSensor.AddReading(23.9f, 1.5f, 6.4f, 9.5f);
            airSensor.AddReading(23.0f, 1.1f, 5.8f, 9.4f);
            airSensor.AddReading(51.4f, 1.2f, 5.5f, 9.2f);
            airSensor.AddReading(67.9f, 1.7f, 6.6f, 11.3f);
            airSensor.AddReading(51.6f, 1.5f, 5.8f, 9.2f);

           
            // 10 readings for WaterQualitySensor 
            waterSensor.AddReading(26.3f, 1.3f, 0.1f, 0.0f);
            waterSensor.AddReading(23.4f, 1.5f, 0.1f, 0.0f);
            waterSensor.AddReading(28.9f, 1.3f, 0.1f, 0.0f);
            waterSensor.AddReading(22.5f, 1.4f, 0.1f, 0.0f);
            waterSensor.AddReading(29.4f, 1.6f, 0.0f, 0.0f);
            waterSensor.AddReading(25.2f, 1.4f, 0.0f, 0.0f);
            waterSensor.AddReading(25.4f, 1.3f, 0.0f, 0.0f);
            waterSensor.AddReading(23.2f, 1.6f, 0.0f, 0.0f);
            waterSensor.AddReading(27.3f, 1.3f, 0.1f, 0.0f);
            waterSensor.AddReading(29.1f, 1.4f, 0.1f, 0.0f);

          
            // 10 readings for WeatherQualitySensor 
            weatherSensor.AddReading(0.6f, 98.0f, 1.2f, 78.0f);
            weatherSensor.AddReading(2.4f, 96.0f, 0.9f, 106.0f);
            weatherSensor.AddReading(2.5f, 97.0f, 1.1f, 103.0f);
            weatherSensor.AddReading(2.4f, 97.0f, 1.5f, 142.0f);
            weatherSensor.AddReading(1.9f, 96.0f, 2.2f, 179.0f);
            weatherSensor.AddReading(3.1f, 93.0f, 3.4f, 179.0f);
            weatherSensor.AddReading(3.5f, 93.0f, 3.7f, 178.0f);
            weatherSensor.AddReading(3.5f, 94.0f, 3.5f, 169.0f);
            weatherSensor.AddReading(3.3f, 93.0f, 3.4f, 161.0f);
            weatherSensor.AddReading(3.0f, 95.0f, 3.4f, 152.0f);

            airSensor.MaintenanceDate = DateTime.Now.AddDays(30);
            weatherSensor.MaintenanceDate = DateTime.Now.AddDays(45);
            // waterSensor.MaintenanceDate = null; // not yet scheduled

        
            Sensors = new ObservableCollection<Sensor>
            {
                airSensor,
                waterSensor,
                weatherSensor,


            };
        }
    }
}
