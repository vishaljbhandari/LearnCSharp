using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Events
{
    /*
     * You can use multiple handlers for a single event. 
     * This is implemented using the delegates. When an event is triggered, all subscribed methods are called in the order they were added.
     */

    /*
        The following example demonstrates an event with multiple handlers. 
        In this example, we create a class called WeatherStation. It has an event named OnTemperatureAlert that uses a delegate called TemperatureAlertHandler. 
        When the temperature goes above a set limit, two handlers DisplayDevice and CoolingSystem are called.
     */
    class WeatherStation
    {
        public delegate void TemperatureAlertHandler(string message);
        public event TemperatureAlertHandler OnTemperatureAlert;

        public void CheckTemperature(double temperature)
        {
            Console.WriteLine($"Current temperature is: {temperature}");
            if (temperature > 30)
            {
                OnTemperatureAlert?.Invoke("Temperature too high...");
            }
        }
    }

    class EventWithMultiplehandlers
    {
        static void DisplayDevice(string msg) => Console.WriteLine($"Display shows alert: {msg}");
        static void CoolingSystem(string msg) => Console.WriteLine($"Cooling system activated: {msg}");

        public static void Example()
        {
            WeatherStation station = new WeatherStation();

            station.OnTemperatureAlert += DisplayDevice;
            station.OnTemperatureAlert += CoolingSystem;

            station.CheckTemperature(35.5);
        }
    }
}
