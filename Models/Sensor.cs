using MauiApp1.Models;

namespace MauiApp1.Models
{
    public abstract class Sensor
    {

        public string Name {get; set;}
       // public string sensorType {get;set;}
        public  double Latitude {get; set;}
        public double Longtitude{get; set;}
        public DateTime? MaintenanceDate {get; set;}

        public bool IsFaulty { get; set; } = false;

        public Sensor(string name, double latitude, double longtitude){
            this.Name = name;
            this.Latitude = latitude;
            this.Longtitude = longtitude;
            this.MaintenanceDate = null;
        }
        public string LocationDisplay => $"Lat: {Latitude:F4}, Lon: {Longtitude:F4}";

        public DateTime LastReadingTime { get; set; } = DateTime.Now;

        public string OperationalStatus
        {
            get
            {
                var minutesAgo = (DateTime.Now - LastReadingTime).TotalMinutes;
                if (minutesAgo < 5) return "OK";
                if (minutesAgo < 15) return "Risk";
                return "Issue";
            }
        }

    }

    public class AirQualitySensor : Sensor
    {
        public List<AirQualityReading> airReadings {get;set;} = new();
        public AirQualitySensor(double latitude, double longtitude) :
        base("Air Quality Sensor", latitude,longtitude){}

        public void AddReading (float no2, float so2, float pm25, float pm10)
        {
            airReadings.Add(new AirQualityReading(no2,so2,pm25,pm10));
            LastReadingTime = DateTime.Now;
        }
    }

    public class WaterQualitySensor : Sensor
    {
        public List<WaterQualityReading> waterReadings {get;set;} = new();

        public WaterQualitySensor(double latitude, double longtitude):
        base("Water Quality Sensor", latitude, longtitude){} 

        public void AddReading(float nitrate, float nitrite, float phosphate, float eColi)
        {
            waterReadings.Add(new WaterQualityReading(nitrate, nitrite,  phosphate, eColi));
            LastReadingTime = DateTime.Now;


        }
     }

     public class WeatherQualitySensor : Sensor
     {
        public List <WeatherQualityReading> weatherReadings {get; set;} = new ();

        public WeatherQualitySensor(double latitude, double longtitude):
        base("Weather Quality Sensor", latitude, longtitude){}

        public void AddReading(float temperature, float humidity, float windSpeed, float windDirection)
        {
            weatherReadings.Add(new WeatherQualityReading(temperature, humidity, windSpeed, windDirection));
            LastReadingTime = DateTime.Now;
        }
     }



}