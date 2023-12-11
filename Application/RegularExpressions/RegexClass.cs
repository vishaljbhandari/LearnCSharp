using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Application.RegularExpressions
{
    class RegexClass
    {
        /* The Regex class is used for representing a regular expression. 
         * It has the following commonly used methods */

        void isMatchMethod()
        {
            /*
             * public bool IsMatch(string input)
                Indicates whether the regular expression specified in the Regex constructor finds a match in a specified input string. */


            /*
             * public bool IsMatch(string input, int startat)
                Indicates whether the regular expression specified in the Regex constructor finds a match in the specified input string, beginning at the specified starting position in the string. */

            /*
             * public static bool IsMatch(string input, string pattern)
                Indicates whether the specified regular expression finds a match in the specified input string. */

        }
        void matchesMethod()
        {
            /*
             * public MatchCollection Matches(string input)
                Searches the specified input string for all occurrences of a regular expression. */
            string text1 = "make maze and manage to measure it";
            string expr1 = @"\bm\S*e\b";
            

            Console.WriteLine("The Expression: " + expr1);
            MatchCollection mc1 = Regex.Matches(text1, expr1);

            foreach (Match m in mc1)
            {
                Console.WriteLine(m);
            }

            string text2 = "A Thousand Splendid Suns";
            string expr2 = @"\bS\S*";
            Console.WriteLine("The Expression: " + expr2);
            MatchCollection mc2 = Regex.Matches(text2, expr2);

            foreach (Match m in mc2)
            {
                Console.WriteLine(m);
            }
        }

        void replaceMethod()
        {
            /*
             * public string Replace(string input, string replacement)
                In a specified input string, replaces all strings that match a regular expression pattern with a specified replacement string. */
            string input = "Hello   World   ";
            string pattern = "\\s+";
            string replacement = " ";

            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);
        }

        void splitMethod()
        {
            /*
             * public string[] Split(string input)
                Splits an input string into an array of substrings at the positions defined by a regular expression pattern specified in the Regex constructor. */

        }
        public static void Example()
        {
            RegexClass obj = new RegexClass();
            obj.isMatchMethod();
            obj.matchesMethod();
            obj.replaceMethod();
            obj.splitMethod();
        }
    }
}
