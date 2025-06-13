using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.ClassMembers.Properties
{
    class Employee
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                // Just before setting value, validate value and throw exception
                if (value < 18)
                    throw new ArgumentException("Minimum age is 18.");
                age = value;
            }
        }
    }
    class PropertyValidation
    {
        /*
         * You can use validation inside a property's set accessor to restrict invalid values
         */
        public static void Example()
        {
            Employee emp = new Employee();
            emp.Age = 25;
            Console.WriteLine("Age: " + emp.Age);
        }
    }
}
