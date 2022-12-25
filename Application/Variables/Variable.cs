using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Variables
{
    class Variable
    {
        /*
         * Variable is a name given to a storage location in memory
         * 
         * 
         * 
         */
        void Declaration()
        {
#pragma warning disable 219, 168
            int UnInitializedNumber;
            int InitializedNumber = 5;

            float marks = 5.4f;
            char choice = 'C';
#pragma warning restore 219, 168
        }

        void Initialization()
        {

        }
        static void Example()
        {
            Variable variable = new Variable();
            variable.Declaration();
            variable.Initialization();
        }
    }
}
