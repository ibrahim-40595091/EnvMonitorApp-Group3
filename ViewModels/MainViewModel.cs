using System.Collections.ObjectModel;
using MauiApp1.Models;  

namespace MauiApp1.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Sensor> Sensors { get; set; }

        public MainViewModel()
        {
            var airSensor = new AirQualitySensor(55.94476, -3.183991
);
            var waterSensor = new WaterQualitySensor(55.8611, -3.2539); 
            var weatherSensor = new WeatherQualitySensor(55.008785,-3.5856323); 

            airSensor.AddReading(26.3925, 1.59654, 5.094, 8.3);
            airSensor.AddReading(22.5675, 1.33045, 5.094, 7.9);

            waterSensor.AddReading(26.33, 1.33, 0.07, 0);
            waterSensor.AddReading(23.4, 1.52, 0.06, 0);

            weatherSensor.AddReading(0.6, 98, 1.18, 78);
            weatherSensor.AddReading(2.4, 96, 0.93, 106);

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
