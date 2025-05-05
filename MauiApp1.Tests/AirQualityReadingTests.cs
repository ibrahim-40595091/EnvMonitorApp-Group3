using MauiApp1.Models;
using Xunit;
using System;

namespace MauiApp1.Tests
{
    public class AirQualityReadingTests
    {
        [Fact]
        public void Constructor_SetsPropertiesCorrectly()
        {
            var now = DateTime.Now;
            var reading = new AirQualityReading(12, 5, 22, 35, now);

            Assert.Equal(12, reading.NO2);
            Assert.Equal(5, reading.SO2);
            Assert.Equal(22, reading.PM25);
            Assert.Equal(35, reading.PM10);
            Assert.Equal(now, reading.Timestamp);
        }
    }
}
