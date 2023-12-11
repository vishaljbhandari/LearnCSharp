using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ExceptionHandling
{
    class ThrowingObjects
    {
        /* Throw statement is used to throw explicit exceptation */
        void throwingException()
        {
            Temperature temp = new Temperature();
            try
            {
                if (temp.temperature == 0)
                {
                    throw (new TempIsZeroException("Zero Temperature found"));
                }
                else
                {
                    Console.WriteLine("Temperature: {0}", temp.temperature);
                }
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
                /* exception can be rethrown again from a catch block for further exception handling */
                throw (new OutOfMemoryException("Out Of Memory"));
            }
            catch (System.OutOfMemoryException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);

            }
        }

        public static void Example()
        {
            ThrowingObjects obj = new ThrowingObjects();
            obj.throwingException();
        }
    }
}