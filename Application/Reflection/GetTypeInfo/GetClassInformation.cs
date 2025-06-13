using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Reflection.GetTypeInfo
{
    /*
     * You can also get the class members using reflection
     * listing properties, methods, and fields of a class
     */
    class Student
    {
        public string Name { get; set; } = "Aarav";
        public int RollNo { get; set; } = 101;
        public string School = "Delhi Public School";

        public void Introduce()
        {
            Console.WriteLine($"Hi, I am {Name}, Roll No: {RollNo}.");
        }
    }
    class GetClassInformation
    {
        public static void Example()
        {
            Type type = typeof(Student);

            Console.WriteLine("Properties:");
            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine(prop.Name);
            }

            Console.WriteLine("Methods:");
            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine("Fields:");
            foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Console.WriteLine(field.Name);
            }
        }
    }
}
