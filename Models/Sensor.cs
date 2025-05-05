using MauiApp1.Models;

namespace MauiApp1.Models
{
    public abstract class Sensor
    {
        public string Name {get; set;}
       // public string sensorType {get;set;}
        public  double Latitude {get; set;}
        public double Longtitude{get; set;}
        public string Location{get;set;}
        public DateTime? MaintenanceDate {get; set;}


        public Sensor(string name, double latitude, double longtitude, string location){
            this.Name = name;
            this.Latitude = latitude;
            this.Longtitude = longtitude;
            this.Location = location;
            this.MaintenanceDate = null;
        }
        public string LocationDisplay => $"Lat: {Latitude:F4}, Lon: {Longtitude:F4}";
    }

    public class AirQualitySensor : Sensor
    {
        public List<AirQualityReading> airReadings {get;set;} = new();
        public AirQualitySensor(double latitude, double longtitude, string location) :
        base("Air Quality Sensor", latitude,longtitude,location){}

        public void AddReading (double no2, double so2, double pm25, double pm10)
        {
            airReadings.Add(new AirQualityReading(no2,so2,pm25,pm10));
        }
    }

    public class WaterQualitySensor : Sensor
    {
        public List<WaterQualityReading> waterReadings {get;set;} = new();

        public WaterQualitySensor(double latitude, double longtitude, string location):
        base("Water Quality Sensor", latitude, longtitude, location){} 

        public void AddReading(double nitrate, double nitrite, double phosphate, double eColi)
        {
            waterReadings.Add(new WaterQualityReading(nitrate, nitrite,  phosphate, eColi));
         
            
        }
     }

     public class WeatherQualitySensor : Sensor
     {
        public List <WeatherQualityReading> weatherReadings {get; set;} = new ();

        public WeatherQualitySensor(double latitude, double longtitude, string location):
        base("Weather Quality Sensor", latitude, longtitude, location){}

        public void AddReading(double temperature, double humidity, double windSpeed, int windDirection)
        {
            weatherReadings.Add(new WeatherQualityReading(temperature, humidity, windSpeed, windDirection));
        }
     }
}