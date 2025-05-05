using System.Collections.ObjectModel;
using System.Windows.Input;
using MauiApp1.Models;
using Microsoft.Maui.Controls;

namespace MauiApp1.ViewModels
{
    public class SensorManagementViewModel : BindableObject
    {
        public ObservableCollection<Sensor> Sensors { get; set; }

        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeactivateCommand { get; }

        public SensorManagementViewModel()
        {
            Sensors = new ObservableCollection<Sensor>
            {
                new AirQualitySensor(51.5, -0.1),
                new WaterQualitySensor(37.7, -122.4),
                new WeatherQualitySensor(48.8, 2.3)
            };

            AddCommand = new Command(AddSensor);
            EditCommand = new Command<Sensor>(EditSensor);
            DeactivateCommand = new Command<Sensor>(DeactivateSensor);
        }

        private void AddSensor()
        {
            Sensors.Add(new AirQualitySensor(55.9, -3.2));
            Application.Current.MainPage.DisplayAlert("Sensor", "New sensor added!", "OK");
        }

        private void EditSensor(Sensor sensor)
        {
            sensor.Latitude += 0.01;
            sensor.Longtitude += 0.01;
            OnPropertyChanged(nameof(Sensors));
            Application.Current.MainPage.DisplayAlert("Sensor", "Sensor location updated!", "OK");
        }

        private void DeactivateSensor(Sensor sensor)
        {
            sensor.IsFaulty = true;
            OnPropertyChanged(nameof(Sensors));
            Application.Current.MainPage.DisplayAlert("Sensor", "Sensor deactivated!", "OK");
        }
    }
}
