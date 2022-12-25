using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Variables
{
    class Constant  /* Also called -> Literal */
    {

        /*
        * Constant is an immutable value.
        * 
        * 
        * 
        */

        void Declaration()
        {
#pragma warning disable 219
            /*
                syntax
                const data_type variable_name = constant_value;

                Constants are declared using "const" keyword

                We can not define a constant wothout setting up its value
                const float Pi;     this is an error as it is uninitialized                
            */
            const float Pi = 3.14f;

            /*
                We can not modify a constant anywhere in the program
                Pi    = 50.1f;      this is not allowed, constants can not be modified
            */
            const int Hundred = 100;
#pragma warning restore 219
        }

        void Initialization()
        {
            /*
             * Constants are initialized along with declaration
             * You can not declare any constant without initializing it.
             */
        }

        void IntegerLiterals()
        {
            /*
             * An integer literal can be a decimal, or hexadecimal constant. 
             * A prefix specifies the base or radix: 0x or 0X for hexadecimal, and there is no prefix id for decimal.
             * Binary literals (Base 2): allowed digits are only 1’s and 0’s.
             * Octal literals (Base 8): allowed digits are 0-7.
             * Hexa-decimal literals (Base 16): allowed digits are 0-9 and characters are a-f. Both uppercase and lowercase characters are allowed.
             */
#pragma warning disable 219
            int a1 = 212;           /* decimal, int */
            byte a3 = 0x4b;         /* hexadecimal */
            uint a5 = 30u;          /* unsigned int */
            // long a6 = 30l;       /* long */ /* warning CS0078: The 'l' suffix is easily confused with the digit '1' -- use 'L' for clarity */
            long a6 = 30L;          /* long */      
            ulong a7 = 30ul;        /* unsigned long */

            int a8 = 0145;          /* octal */
            int c = 0xFace;         /* hexadecimal */
            int x = 0b101;          /* binary */

            /* Illegal Integer Literals
             * 07778    // invalid: 8 is not an octal digit 
             * 045uu    // invalid: suffix (u) is repeated
             * 0b105    // invalid: 5 is not a binary digit
             * 
             */
#pragma warning restore 219
        }

        void FloatingPointLiterals()
        {
            /*
             * A floating-point literal has an integer part, a decimal point, a fractional part, and an exponent part. 
             * You can represent floating point literals either in decimal form or exponential form.
             */
#pragma warning disable 219
            float f1 = 3.14159f;       /* Legal */
            float f2 = 3.14159F;       /* Legal */
            double d1 = 314159E-5F;    /* Legal */
            double d2 = 314159E-5f;    /* Legal */
            // 510E          /* Illegal: incomplete exponent */
            // 210f          /* Illegal: no decimal or exponent */
            // .e55          /* Illegal: missing integer or fraction */
#pragma warning restore 219
        }

        void CharacterConstants()
        {
            /*
             * Character literals are enclosed in single quotes.
             * A character literal can be 
                 * a plain character (such as 'x')
                 * an escape sequence (such as '\t')
                 * a universal character (such as '\u02C0')
             */
#pragma warning disable 219
            char ch1 = 'a';
            char ch2 = '\u0061';// Here /u0061 represent a
            char ch3 = '\n';

            /*
             * There are certain characters in C# when they are preceded by a backslash. 
             * They have special meaning and they are used to represent like newline (\n) or tab (\t)
             */
#pragma warning restore 219
        }

        void StringLiterals()
        {
            /*
             * String literals or constants are enclosed in double quotes "" or with @"". 
             * A string contains characters that are similar to character literals: plain characters, escape sequences, and universal characters.
             * You can break a long line into multiple lines using string literals and separating the parts using whitespaces.
             */
#pragma warning disable 219
            String word = "hello, dear";
            String another_word = @"hello dear";
#pragma warning restore 219
        }

        static void Example()
        {
            Constant constant = new Constant();
            constant.Declaration();
            constant.Initialization();
            constant.IntegerLiterals();
            constant.FloatingPointLiterals();
        }
    }
}
