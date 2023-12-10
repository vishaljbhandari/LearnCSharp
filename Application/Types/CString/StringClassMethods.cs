using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.CString
{
    class StringClassMethods
    {
        void stringCompare()
        {
            /*
                Compare
                public static int Compare (string? strA, string? strB);
                public static int Compare (string? strA, string? strB, bool ignoreCase);

                ignoreCase - true to ignore case during the comparison; otherwise, false.
                return value
                Less than zero	strA precedes strB in the sort order.
                Zero	strA occurs in the same position as strB in the sort order.
                Greater than zero	strA follows strB in the sort order.
            */
            string author1 = "Mahesh Chand";
            string author2 = "Praveen Kumar";

            if (String.Compare(author1, author2) == 0)
                Console.WriteLine($"Both strings have same value.");
            else if (String.Compare(author1, author2) < 0)
                Console.WriteLine($"{author1} precedes {author2}.");
            else
                Console.WriteLine($"{author1} follows {author2}.");

            if (String.Compare(author1, author2, false) == 0)
                Console.WriteLine($"Both strings have same value.");
            else if (String.Compare(author1, author2, false) < 0)
                Console.WriteLine($"{author1} precedes {author2}.");
            else
                Console.WriteLine($"{author1} follows {author2}.");
        }
        void stringConcat()
        {
            /*
                public static string Concat (string? str0, string? str1);
                public static string Concat (string? str0, string? str1, string? str2);
                public static string Concat (string? str0, string? str1, string? str2, string? str2);

                Concate two/three/four strings
            */
            string author1 = "Mahesh Chand";
            string author2 = "Praveen Kumar";
            Console.WriteLine($"Concatenated String - {0}", String.Concat(author1, author2));
            string jointAuthor = String.Concat(author1, author2);
        }

        void stringContain()
        {
            /*
                public bool Contains (char value);
                public bool Contains (string value);

                check if value string/char occurs within the string
            */
            string author = "Mahesh Chand";
            char chValue = 'a';
            if (author.Contains(chValue))
            {
                Console.WriteLine($"{0} contains {1}", author, chValue);
            }
            string strValue = "Chand";
            if (author.Contains(strValue))
            {
                Console.WriteLine($"{0} contains {1}", author, strValue);
            }
        }
        void stringCasing()
        {
            /*
                public string ToUpper();
                public string ToLower();

                returns string in upper or lower casing
            */
            string author = "Vishal Bhandari";
            Console.WriteLine($"{0} in upper case is {1}", author, author.ToUpper());
            Console.WriteLine($"{0} in lower case is {1}", author, author.ToLower());
        }
        void stringTrimming()
        {
            /*
                public string Tim();

                remove all leading and trailing spaces from string
            */
            string author = "  Vishal Bhandari  ";
            Console.WriteLine($"{0} timmed into {1}", author, author.Trim());
        }
        void stringSplitting()
        {
            /*
                public string[] Split(params char[] separator);
                Returns a string array that contains the substrings in the current string object, delimited by elements of a specified Unicode character array.

                public string[] Split(char[] separator, int StringSplitOptions);
                Returns a string array that contains the substrings in the current string object, delimited by elements of a specified Unicode character array. 
                The int parameter specifies the maximum number of substrings to return.

            */
            string message = "You win some. You lose some.";
            string[] substrings1 = message.Split(' ');
            Console.WriteLine($"Substrings of {1} are ", message);
            foreach (var sub in substrings1)
            {
                Console.WriteLine($"Substring: {sub}");
            }

            string[] substrings2 = message.Split(' ', '.');
            Console.WriteLine($"Substrings of {1} are ", message);
            foreach (var sub in substrings2)
            {
                Console.WriteLine($"Substring: {sub}");
            }

            char[] separators = new char[] { ' ', '.' };
            string[] substrings3 = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Substrings of {1} are ", message);
            foreach (var sub in substrings3)
            {
                Console.WriteLine($"Substring: {sub}");
            }
        }

        void stringStartsWith()
        {
            /*
                public bool StartsWith(string value);

                returns true if string starts with specified string
            */
            string author = "Vishal Bhandari  ";
            if (author.StartsWith("Vishal"))
            {
                Console.WriteLine($"{0} starts with Vishal", author);
            }            
        }
        void stringEndsWith()
        {
            /*
                public bool EndsWith(string value);

                returns true if string ends with specified string
            */
            string author = "Vishal Bhandari  ";
            if (author.StartsWith("dari"))
            {
                Console.WriteLine($"{0} ends with dari", author);
            }
        }
        void stringReplace()
        {
            /*
                public string Replace(string oldstring, string newstring);
                returns string after replacing oldstring with newstring

                public string Replace(char oldchar, char newchar);
                returns string after replacing oldchar with newchar
            */
            string author = "Vishal Bhandari  ";
            Console.WriteLine($"a is replaced with g in {0}, and new string is {1}", author, author.Replace('a','g'));
            Console.WriteLine($"sh is replaced with pl in {0}, and new string is {1}", author, author.Replace("sh", "pl"));
        }
        void stringRemoves()
        {
            /*
                public string Remove(int startIndex);
                returns string after removing all characters from given index to end of string

                public string Remove(int startIndex, int count);
                returns string after removing count characters from given index
            */
            string author = "Vishal Bhandari  ";
            Console.WriteLine($"All characters removed after 4th position in {0}, and new string is {1}", author, author.Remove(4));
            Console.WriteLine($"7 characters removed after 4th position in {0}, and new string is {1}", author, author.Remove(4, 7));
        }
        void stringLastIndexOf()
        {
            /*
                public int LastIndexOf(char value);
                returns the position of last index of specified character, if not found then returns -1

                public int LastIndexOf(string value);
                returns the position of last index of specified strings, if not found then returns -1
            */
            string author = "Vishal Bhandari is author of this book. He wrote this book";
            Console.WriteLine($"'a' Lastly found at {0} in string {1}", author.LastIndexOf('a'), author);
            Console.WriteLine($"'book' Lastly found at {0} in string {1}", author.LastIndexOf("book"), author);
        }
        void stringJoin()
        {
            /*
                public static string Join(string seperator, params string[] value);
                returns string after joining strings with specified seperator

                public static string Join(string seperator, string[] value, int startIndex, int count);
                
            */
            string[] msg = { "Hello", "Vishal", "How", "are", "you" };
            Console.WriteLine($"joined string is {0}", String.Join(" ", msg));
        }
        void stringIsNullOrEmpty()
        {
            /*
                public static bool IsNullOrEmpty(string value);
                checks if specified string is null or empty
                
            */
            string msg = "";
            if (String.IsNullOrEmpty(msg))
            {
                Console.WriteLine($"{0} is empty or null", msg);
            }
        }
        void stringInsert()
        {
            /*
                public string Insert(int startIndex, string value);
                returning string after inserting value string at specified index of given string
                
            */
            string author = "Vishal Bhandari";
            Console.WriteLine($"Inserted string is {0}", author.Insert(5, "Hello"));
        }
        void stringIndexOf()
        {
            /*
                public int IndexOf(char value);
                returns the first occurance of char value, if not found then returns -1

                public int IndexOf(string value);
                returns the first occurance of string value, if not found then returns -1

                public int IndexOf(char value, int startIndex);
                returns the first occurance of char value, if not found then returns -1
                search starts from given start index

                public int IndexOf(string value, int startIndex);
                returns the first occurance of string value, if not found then returns -1
                search starts from given start index

            */
            string author = "Vishal Bhandari";
            Console.WriteLine($"Found firstly in {0} at {1}", author, author.IndexOf('a'));
            Console.WriteLine($"Found firstly in {0} at {1}", author, author.IndexOf("sh"));
            Console.WriteLine($"Found firstly in {0} at {1}", author, author.IndexOf('a', 2));
            Console.WriteLine($"Found firstly in {0} at {1}", author, author.IndexOf("sh", 2));
        }
        void stringIndexOfAny()
        {
            /*
                public int IndexOfAny(char[] value);
                returns the first occurance of char values, if not found then returns -1

                public int IndexOfAny(char[] value, int startIndex);
                returns the first occurance of char values, if not found then returns -1
                search starts from given start index

            */
            string author = "Vishal Bhandari";
            char[] values = { 'a', 'g', 'j' };
            Console.WriteLine($"Found firstly in {0} at {1}", author, author.IndexOfAny(values));
            Console.WriteLine($"Found firstly in {0} at {1}", author, author.IndexOfAny(values, 2));
        }

        [Obsolete]
        void stringCopy()
        {
            /*
                public static string Copy(string str);
                returns a copied string

            */
            string author = "Vishal Bhandari";
            string copied = String.Copy(author);
            Console.WriteLine($"Copied string {1}", copied);
        }
        void stringCopyTo()
        {
            /*
                public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count);
                returns a copied string from source index upto count cahracters to destination string starting at destination index

            */
            string author = "Vishal Bhandari";
            char[] destination = new char[25];
            author.CopyTo(1, destination, 3, 4);
            Console.WriteLine($"Copied string {1}", destination);
        }
        void stringEquals()
        {
            /*
                public bool Equals(string value);
                public static bool Equals(string one, string two);
                checks if string is equal to value string

            */
            string author1 = "Vishal Bhandari";
            string author2 = "Vishal Bhandari  ";
            if (author1.Equals(author2))
            {
                Console.WriteLine($"{0} and {1} are equal", author1, author2);
            }
            if (String.Equals(author1, author2))
            {
                Console.WriteLine($"{0} and {1} are equal", author1, author2);
            }
        }
        void stringFormat()
        {
            /*
                public static string Format(string format, object arg0);
                replace one or more format items in a specified string with the string represention of a specified object

            */
            Decimal pricePerOunce = 17.36m;
            Console.WriteLine($"Formated string {1}", String.Format("The current price is {0:C2} per ounce.",
                         pricePerOunce));
            Console.WriteLine($"Formated string {1}", String.Format("At {0}, the temperature is {1}°C.",
                         DateTime.Now, 20.4));
            Console.WriteLine($"Formated string {1}", String.Format("It is now {0:d} at {0:t}", DateTime.Now));
            Console.WriteLine($"Formated string {1}", String.Format("{0,6} {1,15:N0}\n", 5, 7));
        }

        [Obsolete]
        public static void Example()
        {
            StringClassMethods obj = new StringClassMethods();
            obj.stringCompare();
            obj.stringConcat();
            obj.stringContain();
            obj.stringCasing();
            obj.stringTrimming();
            obj.stringSplitting();
            obj.stringStartsWith();
            obj.stringEndsWith();
            obj.stringReplace();
            obj.stringRemoves();
            obj.stringLastIndexOf();
            obj.stringJoin();
            obj.stringIsNullOrEmpty();
            obj.stringInsert();
            obj.stringIndexOf();
            obj.stringIndexOfAny();
            obj.stringCopy();
            obj.stringCopyTo();
            obj.stringEquals();
            obj.stringFormat();
        }
    }
}
