using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Application.Reflection.GetTypeInfo
{
    /*
     * You can retrieve type metadata using the typeof keyword or the GetType() method.
     */

    class Person
    {
        public int Id { get; set; }
        public void Greet()
        {
            Console.WriteLine("Namaste from Greet!");
        }
    }

    class TypeInformation
    {
        public static void Example()
        {
            Type type = typeof(Person);

            Console.WriteLine("Class Name: " + type.Name);
            Console.WriteLine("Namespace: " + type.Namespace);
        }
    }
}


