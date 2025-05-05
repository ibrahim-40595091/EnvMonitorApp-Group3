using MauiApp1.Models;
using Xunit;
using System;

namespace MauiApp1.Tests
{
    public class WaterQualityReadingTests
    {
        [Fact]
        public void Constructor_SetsPropertiesCorrectly()
        {
            var now = DateTime.Now;
            var reading = new WaterQualityReading(4.5f, 1.2f, 3.8f, 0.1f, now);

            Assert.Equal(4.5f, reading.Nitrate);
            Assert.Equal(1.2f, reading.Nitrite);
            Assert.Equal(3.8f, reading.Phosphate);
            Assert.Equal(0.1f, reading.EColi);
            Assert.Equal(now, reading.Timestamp);
        }
    }
}
