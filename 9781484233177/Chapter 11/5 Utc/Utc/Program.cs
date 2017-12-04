using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Current time serves as input
            DateTime now = DateTime.Now;
            DateTime utcNow = DateTime.UtcNow;
            DateTimeOffset completeInstant = DateTimeOffset.Now;
            DateTimeOffset utcCompleteInstant = DateTimeOffset.UtcNow;

            // Outputs
            Console.WriteLine("Now: " + now);
            Console.WriteLine("UTC now: " + utcNow);
            Console.WriteLine("Now (including time zone): " + completeInstant);
            Console.WriteLine("Time zone (offset against UTC): " + completeInstant.Offset.TotalHours);
            Console.WriteLine("UTC now (including time zone): " + utcCompleteInstant);

            // Waiting for Enter
            Console.ReadLine();
        }
    }
}
