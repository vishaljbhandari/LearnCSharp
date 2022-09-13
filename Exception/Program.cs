using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    public class UserException : SystemException
    {
        public UserException(string message) : base(message) { }
    }

    public class TempIsZeroException : SystemException
    {
        public TempIsZeroException(string message) : base(message) { }
    }

    class DivNumbers
    {
        int result;
        DivNumbers() {
            result = 0;
        }
        public void division(int num1, int num2) {
            try {
                result = num1 / num2;
                if(num2 == 5) {
                    throw new UserException("Exception caught, Number is 5");
                }
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally {
                Console.WriteLine("Result: {0}", result);
            }
        }

        public class Temperature {
            int temperature = 0;
            public void showTemp() {
                if (temperature == 0) {
                    throw (new TempIsZeroException("Zero Temperature found"));
                } else {
                    Console.WriteLine("Temperature: {0}", temperature);
                }
            }
        }

        static void Main(string[] args) {
            DivNumbers d = new DivNumbers();
            try {
                d.division(25, 0);

                d.division(25, 5);
            }
            catch (UserException e) {
                Console.WriteLine("Exception caught: {0}", e);
            }

            Temperature temp = new Temperature();
            try {
                temp.showTemp();
            } catch (TempIsZeroException e) {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }

            Console.ReadKey();
        }
    }
}
