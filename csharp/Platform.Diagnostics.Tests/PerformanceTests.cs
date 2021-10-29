using System;
using Xunit;

namespace Platform.Diagnostics.Tests
{
    public class PerformanceTests
    {
        [Fact]
        public void MeasureTest()
        {
            var result = 0;
            var measurement = Performance.Measure(() => result = 1 + 1);
            Assert.Equal(2, result);
            Assert.True(measurement > TimeSpan.Zero);
        }
    }
}
