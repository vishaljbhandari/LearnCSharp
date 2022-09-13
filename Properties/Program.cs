using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Properties
    Named members of classes, structures, and interfaces.
    Member variables or methods in a class or structures are called Fields.
    Properties are an extension of fields and are accessed using the same syntax.
    They use accessors through which the values of the private fields can be read, written or manipulated.

Properties do not name the storage locations.Instead, they have accessors that read, write, or compute their values.

For example, let us have a class named Student, with private fields for age, name, and code.
We cannot directly access these fields from outside the class scope, but we can have properties for accessing these private fields.

Accessors
    The accessor of a property contains the executable statements that helps in getting(reading or computing) or setting(writing) the property.
    The accessor declarations can contain a get accessor, a set accessor, or both. For example −

*/

namespace Properties {

    public abstract class Person {  // Abstract Properties
        // An abstract class may have an abstract property, which should be implemented in the derived class
        public abstract string Name {
            get;
            set;
        }
        public abstract int Age {
            get;
            set;
        }
    }
    class Student : Person {
        private string code = "N.A";    // code property
        private string name = "N.A";    // name property
        private int age = 0;            // age property

        // Declare a Code property of type string:
        public string Code {
            get {
                return code;
            }
            set {
                code = value;
            }
        }

        // Declare a Name property of type string:
        public override string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        // Declare a Age property of type int:
        public override int Age {
            get {
                return age;
            }
            set {
                age = value;
            }
        }
        public override string ToString() {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }

    class Program {
        static void Main(string[] args) {

            // Create a new Student object:
            Student student = new Student();

            // Setting code, name and the age of the student
            student.Code = "001";
            student.Name = "Zara";
            student.Age = 9;
            Console.WriteLine("Student Info: {0}", student);

            //let us increase age
            student.Age += 1;
            Console.WriteLine("Student Info: {0}", student);

            Console.ReadKey();

        }
    }
}
