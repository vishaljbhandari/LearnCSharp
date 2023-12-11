using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ExceptionHandling
{
    class Exceptions
    {
        /*
         * An exception is a problem that arises during the runtime/execution of a program
         * 
         * 
         * Exceptions provide a way to transfer control from one part of a program to another part where that exception is handled
         */

        void fourKeywords()
        {
            /*
                try − A try block identifies a block of code for which particular exceptions is activated.
                        It is followed by one or more catch blocks.
           
                catch − A program catches an exception with an exception handler at the place in a program where you want to handle the problem
                        The catch keyword indicates the catching of an exception.
           
                finally − The finally block is used to execute a given set of statements, whether an exception is thrown or not thrown
                    For example, if you open a file, it must be closed whether an exception is raised or not

                throw − A program throws an exception when a problem shows up
                    This is done using a throw keyword
                    throw statement should be with in try block
            */
            /*
                try
                {
                    // statements causing exception
                }
                catch (ExceptionName e1)
                {
                    // error handling code
                }
                catch (ExceptionName e2)
                {
                    // error handling code
                }
                catch (ExceptionName eN)
                {
                    // error handling code
                }
                finally
                {
                    // statements to be executed
                }
            */
        }


        public static void Example()
        {
            ExceptionClasses.Example();
            HandlingException.Example();
            ThrowingObjects.Example();
        }
    }
}
