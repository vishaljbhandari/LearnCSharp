#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.Collections.Generic;

/*

    Attribute - a declarative tag that is used to convey information to runtime about the behaviors of various elements like classes, methods, structures, enumerators, assemblies etc. 
    
    in your program. You can add declarative information to a program by using an attribute. 
    
    A declarative tag is depicted by square ([ ]) brackets placed above the element it is used for.

    Attributes are used for adding metadata, such as compiler instruction and other information such as comments, description, methods and classes to a program. 
    The .Net Framework provides two types of attributes: 
        Pre-defined attributes
        Custom built attributes.

Specifying an Attribute(Syntax)

    [attribute(positional_parameters, name_parameter = value, ...)]
    element     // above atribute will be applicable to the element next to atribute declaration

Name of the attribute and its values are specified within the square brackets, before the element to which the attribute is applied. 
Positional parameters specify the essential information and the name parameters specify the optional information.

Predefined Attributes
The .Net Framework provides three pre-defined attributes −
    AttributeUsage
    Conditional
    Obsolete

*/

/*
AttributeUsage
    The pre-defined attribute AttributeUsage describes how a custom attribute class can be used. It specifies the types of items to which the attribute can be applied.

    Syntax-
    [AttributeUsage (
       validon,
       AllowMultiple = allowmultiple,
       Inherited = inherited
    )]
    OR
    [AttributeUsage (validon, AllowMultiple = allowmultiple, Inherited = inherited)]

    Where,
    The parameter validon specifies the language elements on which the attribute can be placed. It is a combination of the value of an enumerator AttributeTargets. The default value is AttributeTargets.All.
    The parameter allowmultiple (optional) provides value for the AllowMultiple property of this attribute, a Boolean value. If this is true, the attribute is multiuse. The default is false (single-use).
    The parameter inherited (optional) provides value for the Inherited property of this attribute, a Boolean value. If it is true, the attribute is inherited by derived classes. The default value is false (not inherited).

    Example-
    [AttributeUsage( AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Property,  AllowMultiple = true)]

*/


/*

Conditional
    This predefined attribute marks a conditional method whose execution depends on a specified preprocessing identifier.
    It causes conditional compilation of method calls, depending on the specified value such as Debug or Trace. 
    
    Syntax-
    [Conditional(conditionalSymbol)]
    method

    Example-
    [Conditional("DEBUG")]      // It displays the values of the variables while debugging a code.
    void fun() { Myclass.Message("In Function 2."); }

*/


/*
Obsolete
    This predefined attribute marks a program entity that should not be used. 
    It enables you to inform the compiler to discard a particular target element. 
    
    For example, when a new method is being used in a class and if you still want to retain the old method in the class, 
    you may mark it as obsolete by displaying a message the new method should be used, instead of the old method.

    Syntax −

    [Obsolete (message )]

    [Obsolete ( message, iserror )]

    Where,

    The parameter message, is a string describing the reason why the item is obsolete and what to use instead.
    The parameter iserror, is a Boolean value. If its value is true, the compiler should treat the use of the item as an error. Default value is false (compiler generates a warning).
    

*/
namespace Attributes {

    public class Myclass {

        [Conditional("DEBUG")]
        public static void Msg(string msg) {
            Console.WriteLine(msg);
        }

        [Conditional("DEBUG")]
        public static void Message(string msg) {
            Console.WriteLine(msg);
        }

        public static void alert(string msg) {
            Console.WriteLine(msg);
        }
    }

    // New Example --------------------------------

    [AttributeUsage(AttributeTargets.All)]
    public class MyAttribute : Attribute
    {

        // Provides name of the member
        private string name;

        // Provides description of the member
        private string action;

        // Constructor
        public MyAttribute(string name, string action)
        {
            this.name = name;
            this.action = action;
        }

        // property to get name
        public string Name
        {
            get { return name; }
        }

        // property to get description
        public string Action
        {
            get { return action; }
        }
    }

    class Student
    {
        // Private fields of class Student
        private int rollNo;
        private string stuName;
        private double marks;

        // The attribute MyAttribute is applied 
        // to methods of class Student
        // Providing details of their utility
        [MyAttribute("Modifier", "Assigns the Student Details")]
        public void setDetails(int r, string sn, double m)
        {
            rollNo = r;
            stuName = sn;
            marks = m;
        }

        [MyAttribute("Accessor", "Returns Value of rollNo")]
        public int getRollNo()
        {
            return rollNo;
        }

        [MyAttribute("Accessor", "Returns Value of stuName")]
        public string getStuName()
        {
            return stuName;
        }

        [MyAttribute("Accessor", "Returns Value of marks")]
        public double getMarks()
        {
            return marks;
        }
    }


    // New Example -------------------------

    // Defining a Custom attribute class
    class NewAttribute : Attribute
    {

        // Private fields
        private string title;
        private string description;

        // Parameterised Constructor
        public NewAttribute(string t, string d)
        {
            title = t;
            description = d;
        }

        // Method to show the Fields 
        // of the NewAttribute
        // using reflection
        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("Methods of class {0}", classType.Name);

            // Array to store all methods of a class
            // to which the attribute may be applied

            MethodInfo[] methods = classType.GetMethods();

            // for loop to read through all methods

            for (int i = 0; i < methods.GetLength(0); i++)
            {

                // Creating object array to receive 
                // method attributes returned
                // by the GetCustomAttributes method

                object[] attributesArray = methods[i].GetCustomAttributes(true);

                // foreach loop to read through 
                // all attributes of the method
                foreach (Attribute item in attributesArray)
                {
                    if (item is NewAttribute)
                    {

                        // Display the fields of the NewAttribute
                        NewAttribute attributeObject = (NewAttribute)item;
                        Console.WriteLine("{0} - {1}, {2} ", methods[i].Name,
                         attributeObject.title, attributeObject.description);
                    }
                }
            }
        }
    }

    // Class Employer
    class Employer
    {

        // Fields of Employer
        int id;
        string name;

        // Constructor
        public Employer(int i, string n)
        {
            id = i;
            name = n;
        }

        // Applying the custom attribute 
        // NewAttribute to the getId method
        [NewAttribute("Accessor", "Gives value of Employer Id")]
        public int getId()
        {
            return id;
        }

        // Applying the custom attribute 
        // NewAttribute to the getName method
        [NewAttribute("Accessor", "Gives value of Employer Name")]
        public string getName()
        {
            return name;
        }
    }

    // Class Employee
    class Employee
    {

        // Fields of Employee
        int id;
        string name;

        public Employee(int i, string n)
        {
            id = i;
            name = n;
        }

        // Applying the custom 
        // attribute NewAttribute
        // to the getId method
        [NewAttribute("Accessor", "Gives value of Employee Id")]
        public int getId()
        {
            return id;
        }

        // Applying the custom attribute 
        // NewAttribute to the getName method
        [NewAttribute("Accessor", "Gives value of Employee Name")]
        public string getName()
        {
            return name;
        }
    }


    class Test {
        [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
        static void OldMethod() {     // this message is not used for compilation
            Console.WriteLine("It is the old method");
        }

        static void NewMethod() {
            Console.WriteLine("It is the new method");
        }

        public static void Main() {
            Myclass.Message("In Main function.");
            Myclass.Message("In Function 1.");
            Myclass.Msg("In Function Msg.");
            Myclass.alert("In Function Alert.");

            // OldMethod();    // Compilation Error = "Don't use OldMethod, use NewMethod instead"

            // Use of custom attributes
            Student s = new Student();
            s.setDetails(1, "Taylor", 92.5);

            Console.WriteLine("Student Details");
            Console.WriteLine("Roll Number : " + s.getRollNo());
            Console.WriteLine("Name : " + s.getStuName());
            Console.WriteLine("Marks : " + s.getMarks());

            // Calling the AttributeDisplay
            // method using the class name
            // since it is a static method
            NewAttribute.AttributeDisplay(typeof(Employer));

            Console.WriteLine();

            NewAttribute.AttributeDisplay(typeof(Employee));

            Console.ReadKey();
        }
    }
}
