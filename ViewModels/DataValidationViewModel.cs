using System.Collections.ObjectModel;
using MauiApp1.Models;
using Microsoft.Maui.Graphics;

namespace MauiApp1.ViewModels
{
    public class DataValidationViewModel
    {
        public ObservableCollection<ValidatableSensor> Sensors { get; set; }

        public DataValidationViewModel()
        {
            Sensors = new ObservableCollection<ValidatableSensor>
            {
                new ValidatableSensor(new AirQualitySensor(51.5074, -0.1278)),
                new ValidatableSensor(new WaterQualitySensor(37.7749, -122.4194)),
                new ValidatableSensor(new WeatherQualitySensor(48.8566, 2.3522))
            };
        }

        public void RunValidation()
        {
            var random = new Random();

            foreach (var sensor in Sensors)
            {
                bool isValid = random.Next(0, 2) == 1;

                sensor.ValidityStatus = isValid ? "Valid" : "Warning";
                sensor.BadgeColor = isValid ? Colors.Green : Colors.Orange;
            }
        }
    }

    public class ValidatableSensor : Sensor
    {
        public string ValidityStatus { get; set; } = "Checked";
        public Color BadgeColor { get; set; } = Colors.Green;

        public ValidatableSensor(Sensor baseSensor) 
            : base(baseSensor.Name, baseSensor.Latitude, baseSensor.Longtitude)
        {
        }
    }
}
