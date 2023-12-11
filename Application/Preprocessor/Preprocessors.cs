using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Application.Preprocessor
{
    class Preprocessors
    {
        /* The preprocessor directives 
         *  give instruction to the compiler to preprocess the information 
         *  before actual compilation starts 
         * 
         * All preprocessor directives begin with #
         *  only white-space characters may appear before a preprocessor directive on a line
         *  
         * Preprocessor directives are not statements, 
         *  so they do not end with a semicolon (;)
         *  
         * Cannot define/undefine preprocessor symbols after first token in file
         */
        void regionProcessor()
        {
            /*
                #region
                    It lets you specify a block of code that you can expand or collapse when using the outlining feature of the Visual Studio Code Editor.

                #endregion
                    It marks the end of a #region block.
             */
        }
        void errorWarningProcessor()
        {
            /*
                #line
                It lets you modify the compiler's line number and (optionally) the file name output for errors and warnings.

                #error
                It allows generating an error from a specific location in your code.

                #warning
                It allows generating a level one warning from a specific location in your code.
             */
        }
        public static void Example()
        {
            Preprocessors obj = new Preprocessors();
            obj.regionProcessor();
            obj.errorWarningProcessor();

            Conditional.Example();
            Define.Example();
        }
    }
}
