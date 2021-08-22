using System;
using Xunit;

namespace Platform.Diagnostics.Tests
{
    /// <summary>
    /// <para>
    /// Represents the performance tests.
    /// </para>
    /// <para></para>
    /// </summary>
    public class PerformanceTests
    {
        /// <summary>
        /// <para>
        /// Tests that measure test.
        /// </para>
        /// <para></para>
        /// </summary>
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
