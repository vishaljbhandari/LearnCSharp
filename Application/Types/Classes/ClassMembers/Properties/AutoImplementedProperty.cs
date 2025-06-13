using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Classes.ClassMembers.Properties
{
    class AutoImplementedProperty
    {
        /*
         * an auto-implemented property also known as an automatic property. 
         * It is a short-hand method to define the property. 
         * It allows us to declare a property without explicitly defining a backing field. 
         * The complier automatically generates the field behind the scene.
         */

        class AIStudent
        {
            // Auto-implemented properties
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public static void Example()
        {
            AIStudent s = new AIStudent();

            // Setting property values
            s.Name = "Aman";
            s.Age = 20;

            Console.WriteLine($"Name: {s.Name}, Age: {s.Age}");
        }
    }
}
