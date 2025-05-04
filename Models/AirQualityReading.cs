namespace MauiApp1.Models
{
        public class AirQualityReading
    {
        public DateTime Timestamp { get; set; }
        public double No2 { get; set; }
        public double So2 { get; set; }
        public double PM25 { get; set; }
        public double PM10 { get; set; }

        public AirQualityReading(double no2, double so2, double pm25, double pm10)
        {
            Timestamp = DateTime.Now;
            No2 = no2;
            So2 = so2;
            PM25 = pm25;
            PM10 = pm10;
        }
    }
}