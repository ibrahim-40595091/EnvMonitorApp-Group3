using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using MauiApp1.Models;

namespace MauiApp1.ViewModels
{
    public class HistoricalDataViewModel : BindableObject
    {
        public ObservableCollection<Sensor> Sensors { get; set; }
        public Sensor SelectedSensor { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now.AddDays(-7);
        public DateTime EndDate { get; set; } = DateTime.Now;
        public string ChartImage { get; set; }

        public ICommand ShowChartCommand { get; }
        public ICommand ExportCsvCommand { get; }
        public ICommand ExportPdfCommand { get; }

        public HistoricalDataViewModel()
        {
            // Use hardcoded example sensors
            Sensors = new ObservableCollection<Sensor>
            {
                new AirQualitySensor(51.5, -0.1),
                new WaterQualitySensor(37.7, -122.4),
                new WeatherQualitySensor(55.0088, -3.5856)
            };

            ShowChartCommand = new Command(ShowChart);
            ExportCsvCommand = new Command(ExportCsv);
            ExportPdfCommand = new Command(ExportPdf);
        }

        private void ShowChart()
        {
            // Fake chart image - just use an embedded placeholder image or a local asset
            ChartImage = "chart_placeholder.png";
            OnPropertyChanged(nameof(ChartImage));
        }

        private void ExportCsv()
        {
            Application.Current.MainPage.DisplayAlert("Export", "CSV exported successfully!", "OK");
        }

        private void ExportPdf()
        {
            Application.Current.MainPage.DisplayAlert("Export", "PDF exported successfully!", "OK");
        }
    }
}
