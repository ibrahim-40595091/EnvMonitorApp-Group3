using MauiApp1.Models;
using Xunit;
using System;

namespace MauiApp1.Tests
{
    public class WeatherReadingTests
    {
        [Fact]
        public void Constructor_SetsPropertiesCorrectly()
        {
            var now = DateTime.Now;
            var reading = new WeatherQualityReading(23, 55, 12, 90, now);

            Assert.Equal(23, reading.Temperature);
            Assert.Equal(55, reading.Humidity);
            Assert.Equal(12, reading.WindSpeed);
            Assert.Equal(90, reading.WindDirection);
            Assert.Equal(now, reading.Timestamp);
        }
    }
}
