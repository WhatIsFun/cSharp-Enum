using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Enum
{
    internal class Traffic
    {
        public static void trafficLight()
        {
            while (true)
            {
                foreach (TrafficLight light in Enum.GetValues(typeof(TrafficLight)))
                {
                    Console.WriteLine(light);

                    if (light == TrafficLight.Red)
                    {
                        // (Thread.Sleep) method that suspends the current thread for a specified amount of time to pause.
                        Thread.Sleep(10000); // The number in millisecond which is pause for 10s.
                    }
                    else if (light == TrafficLight.Yellow)
                    {
                        Thread.Sleep(3000); // Pause for 3s.
                    }
                    else if (light == TrafficLight.Green)
                    {
                        Thread.Sleep(5000); // Pause for 5s.
                    }
                }
            }
        }
    }

    enum TrafficLight
    {
        Green,
        Yellow,
        Red
    }
}
