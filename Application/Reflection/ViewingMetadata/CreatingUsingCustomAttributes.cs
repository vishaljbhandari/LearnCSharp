using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Reflection
{
    /*
        Viewing Metadata
        We have mentioned in the preceding chapter that using reflection you can view the attribute information.

        The MemberInfo object of the System.Reflection class needs to be initialized for discovering the attributes associated with a class. To do this, you define an object of the target class, as −

        System.Reflection.MemberInfo info = typeof(MyClass);
     */

    // Define the custom attribute
    [AttributeUsage(AttributeTargets.All)]
    public class HelpAttribute : System.Attribute
    {
        public readonly string Url;

        private string topic;
        public string Topic   // Topic is a named parameter
        {
            get { return topic; }
            set { topic = value; }
        }

        public HelpAttribute(string url)   // url is a positional parameter
        {
            this.Url = url;
        }
    }

    // Apply the attribute to a class
    [Help("Information on the class MyClass", Topic = "Class Info")]
    class MyClass
    {
    }
    class CreatingUsingCustomAttributes
    {
        static void Example()
        {
            System.Reflection.MemberInfo info = typeof(MyClass);
            object[] attributes = info.GetCustomAttributes(true);

            foreach (object attr in attributes)
            {
                HelpAttribute helpAttr = attr as HelpAttribute;
                if (helpAttr != null)
                {
                    Console.WriteLine("Help URL: " + helpAttr.Url);
                    Console.WriteLine("Topic: " + helpAttr.Topic);
                }
            }
        }
    }
}
