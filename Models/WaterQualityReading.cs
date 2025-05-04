namespace MauiApp1.Models
{
    public class WaterQualityReading
    {
        public DateTime Timestamp { get; set; }
        public double Nitrate { get; set; }
        public double Nitrite { get; set; }
        public double Phosphate { get; set; }
        public double EColi { get; set; }

       
        public WaterQualityReading(double nitrate, double nitrite, double phosphate, double eColi)
        {
            Timestamp = DateTime.Now;
            Nitrate = nitrate;
            Nitrite = nitrite;
            Phosphate = phosphate;
            EColi = eColi;
        }
    }
}