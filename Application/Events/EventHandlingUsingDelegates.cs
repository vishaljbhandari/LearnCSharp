using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Events
{
    public delegate void Notify(string message);

    // Publisher class
    class User
    {
        // Declare event
        public event Notify UserLoggedIn;

        public void Login(string username)
        {
            Console.WriteLine($"{username} logged in successfully.");

            // Trigger event
            UserLoggedIn?.Invoke($"Notification: {username} has logged in.");
        }
    }

    // Subscriber class
    class Program
    {
        public static void Example()
        {
            User user = new User();

            // Subscribe to the event
            user.UserLoggedIn += DisplayMessage;

            // Simulate login
            user.Login("JohnDoe");
        }

        // Event handler method
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    class EventHandlingUsingDelegates
    {
        public static void Example()
        {
            Program.Example();
        }
    }
}
