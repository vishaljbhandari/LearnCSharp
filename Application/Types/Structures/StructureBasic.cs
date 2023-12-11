using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Types.Structures
{
    class StructureBasic
    {
        /*
         * In C#, a structure is a value type data type. 
         * used to make a single variable hold related data of various data types. 
         * The struct keyword is used for creating a structure.
         */
        struct Books
        {
            public int id;
            public string title;
            public string author;
            public string subject;

            // constructor 
            public Books(int _id, string _title, string _author, string _subject)
            {
                id = _id;
                title = _title;
                author = _author;
                subject = _subject;
            }

            public void printBook()
            {
                Console.WriteLine("Book 1 title : {0}", title);
                Console.WriteLine("Book 1 author : {0}", author);
                Console.WriteLine("Book 1 subject : {0}", subject);
                Console.WriteLine("Book 1 book_id :{0}", id);
            }
        };

        void definingStructure()
        {
            /* To define a structure, you must use the struct statement */
            /* structure is defined outside the function scope */
        }

        void cSharpStructureFeature()
        {
            /* 
                Structure Features
                Structures can have methods, fields, indexers, properties, operator methods, and events
                Structures can have defined constructors, but not destructors
                The default constructor is automatically defined and cannot be changed
                Unlike classes, structures cannot inherit other structures or classes
                Structures cannot be used as a base for other structures or classes
                A structure can implement one or more interfaces
                Structure members cannot be specified as abstract, virtual, or protected
                When you create a struct object using the New operator, it gets created and the appropriate constructor is called
                Unlike classes, structs can be instantiated without using the New operator
                If the New operator is not used, the fields remain unassigned and the object cannot be used until all the fields are initialized
            */
            /*
                Class versus Structure
                classes are reference types and structs are value types
                structures do not support inheritance
                structures cannot have default constructor
             */
        }

        void usingStructure()
        {
            Books Book1;   /* Declare Book1 of type Book */
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.id = 6495407;

            /* print Book1 info */
            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.id);

            Book1.printBook();
        }

        public static void Example()
        {
            StructureBasic obj = new StructureBasic();
            obj.definingStructure();
            obj.cSharpStructureFeature();
            obj.usingStructure();
        }
    }
}