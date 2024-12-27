using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercism.hyper_optimized_telemetry
{
    public static class TelemetryBuffer
    {
        public static byte[] ToBuffer(long reading)
        {
            ulong ui = (ulong)reading;
            return BitConverter.GetBytes(ui);
        }

        public static long FromBuffer(byte[] buffer)
        {
            throw new NotImplementedException("Please implement the static TelemetryBuffer.FromBuffer() method");
        }
    }
}
