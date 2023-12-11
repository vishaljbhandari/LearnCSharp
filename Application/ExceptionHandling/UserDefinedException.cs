using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ExceptionHandling
{
    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {

        }
    }
    public class Temperature
    {
        public int temperature = 0;

        public void showTemp()
        {

            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperature);
            }
        }
    }
    class UserDefinedException
    {
        /*
         * You can also define your own exception. 
         * User-defined exception classes are derived from the Exception class.
         */
        public static void Example()
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
        }
    }
}
