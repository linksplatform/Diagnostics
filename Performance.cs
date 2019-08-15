using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace Platform.Diagnostics
{
    public static class Performance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TimeSpan Measure(Action action)
        {
            var sw = Stopwatch.StartNew();
            action();
            sw.Stop();
            return sw.Elapsed;
        }
    }
}
