using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Indexers
{

    class Contacts
    {

        /*
         * You can define indexers just like dictionaries where strings can be used as keys. 
         * This type of definition is useful when you want to retrieve or assign values using a string identifier.
         * 
         */
        private Dictionary<string, string> phoneBook = new Dictionary<string, string>();


        public string this[string name]
        {
            get { return phoneBook.ContainsKey(name) ? phoneBook[name] : "Not Found"; }
            set { phoneBook[name] = value; }
        }
    }
    class IndexerWithStringKey
    {
        static void Example()
        {
            Contacts c = new Contacts();
            c["Aman"] = "1234567890";
            c["Ravi"] = "9876543210";

            Console.WriteLine("Aman's Number: " + c["Aman"]);
            Console.WriteLine("Ravi's Number: " + c["Ravi"]);
            Console.WriteLine("Unknown: " + c["Unknown"]);
        }
    }
}
