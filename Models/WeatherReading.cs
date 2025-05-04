namespace MauiApp1.Models
{
    public class WeatherQualityReading
    {
        public DateTime Timestamp { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double WindSpeed { get; set; }
        public double WindDirection { get; set; }

        public WeatherQualityReading(double temperature, double humidity, double windSpeed, double windDirection)
        {
            Timestamp = DateTime.Now;
            Temperature = temperature;
            Humidity = humidity;
            WindSpeed = windSpeed;
            WindDirection = windDirection;
        }
    }
}