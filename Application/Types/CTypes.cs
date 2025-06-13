using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application.Types.ValueTypes;
using Application.Types.ReferenceType;
using Application.Types.PointerType;
using Application.Types.CArray;
using Application.Types.CString;
using Application.Types.Classes.AccessSpecifiers;

namespace Application.Types
{
    class DataTypes
    {
        /* A data type is an attribute associated with a piece of data that tells a computer system how to interpret its value */
    }
    class CTypes
    {
        /*
         * The variables in C#, are categorized into the following types −
         * 1) Value types -> Value type variables can be assigned a value directly
         * 2) Reference types -> The reference types do not contain the actual data stored in a variable, but they contain a reference to the variables
         * 3) Pointer types -> Pointer type variables store the memory address of another type.
         */


        public static void AllTypeSummery()
        {
            // Int Data Types - Signed Integer
            int myFirstInt = 5;  // int number
            int mySecondInt = -5;  // int number Negative
            int myThirdInt = 0;  // int number Zero
            Console.WriteLine("myFirstInt : " + myFirstInt);
            Console.WriteLine("mySecondInt : " + mySecondInt);
            Console.WriteLine("myThirdInt : " + myThirdInt);
            Console.WriteLine("int Range {0} - {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Size of int: {0}", sizeof(int));

            // Unsigned Int Data Types - UnSigned Integer
            uint myFirstUInt = 5;  // uint number
            // uint mySecondUInt = -5;  // uint number Negative // Error
            uint myThirdUInt = 0;  // uint number Zero
            Console.WriteLine("myFirstUInt : " + myFirstUInt);
            /// Console.WriteLine("mySecondUInt : " + mySecondUInt);
            Console.WriteLine("myThirdUInt : " + myThirdUInt);
            Console.WriteLine("uint Range {0} - {1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("Size of uint: {0}", sizeof(uint));

            // Byte Data Types - UnSigned Smaller Integer
            byte myFirstByte = 5;  // Byte number
            // byte mySecondByte = -5;  // Byte number Negative // Error
            byte myThirdByte = 0;  // Byte number Zero
            Console.WriteLine("myFirstByte : " + myFirstByte);
            // Console.WriteLine("mySecondByte : " + mySecondByte);
            Console.WriteLine("myThirdByte : " + myThirdByte);
            Console.WriteLine("byte Range {0} - {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Size of byte: {0}", sizeof(byte));

            // sByte Data Types - Signed Smaller Integer // Signed Byte
            sbyte myFirstSByte = 5;  // SByte number
            sbyte mySecondSByte = -5;  // SByte number Negative
            sbyte myThirdSByte = 0;  // SByte number Zero
            Console.WriteLine("myFirstSByte : " + myFirstSByte);
            Console.WriteLine("mySecondSByte : " + mySecondSByte);
            Console.WriteLine("myThirdSByte : " + myThirdSByte);
            Console.WriteLine("sbyte Range {0} - {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("Size of sbyte: {0}", sizeof(sbyte));


            // Short Data Types - Signed Integer with lesser range
            short myFirstShort = 5;  // short number
            short mySecondShort = -5;  // short number Negative
            short myThirdShort = 0;  // short number Zero
            // short myOverflowShort = 10000000;  // short number with larger value // Error
            Console.WriteLine("myFirstShort : " + myFirstShort);
            Console.WriteLine("mySecondShort : " + mySecondShort);
            Console.WriteLine("myThirdShort : " + myThirdShort);
            Console.WriteLine("short Range {0} - {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("Size of short: {0}", sizeof(short));

            // Unsigned Short Data Types - Unsigned Integer with lesser range
            ushort myFirstUShort = 5;  // ushort number
            // ushort mySecondUShort = -5;  // ushort number Negative   // Not allowed
            ushort myThirdUShort = 0;  // ushort number Zero
            Console.WriteLine("myFirstUShort : " + myFirstUShort);
            // Console.WriteLine("mySecondUShort : " + mySecondUShort);
            Console.WriteLine("myThirdUShort : " + myThirdUShort);
            Console.WriteLine("ushort Range {0} - {1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("Size of ushort: {0}", sizeof(ushort));


            // Long Data Types - Signed Long
            // Long uses Integer values which may signed or unsigned
            long myFirstLong = 1L;  // long number
            long mySecondLong = 1;  // long number
            long myThirdLong = -1L;  // long number 
            long myForthLong = -1;  // long number 
            Console.WriteLine("myFirstLong : " + myFirstLong);
            Console.WriteLine("mySecondLong : " + mySecondLong);
            Console.WriteLine("myThirdLong : " + myThirdLong);
            Console.WriteLine("myForthLong : " + myForthLong);
            Console.WriteLine("long Range {0} - {1}", long.MinValue, long.MaxValue);
            Console.WriteLine("Size of long: {0}", sizeof(long));

            // ULong Data Types - UnSigned Long
            // ULong uses Integer values which may unsigned
            ulong myFirstULong = 1L;  // ulong number
            ulong mySecondULong = 1;  // ulong number
            // ulong myThirdULong = -1L;  // ulong number - no signed numbers
            // ulong myForthULong = -1;  // ulong number  - no signed numbers
            Console.WriteLine("myFirstULong : " + myFirstULong);
            Console.WriteLine("mySecondULong : " + mySecondULong);
            // Console.WriteLine("myThirdULong : " + myThirdULong);
            // Console.WriteLine("myForthULong : " + myForthULong);
            Console.WriteLine("ulong Range {0} - {1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("Size of ulong: {0}", sizeof(ulong));


            // Double Data Types
            // By default fraction value is double in C#
            double myFirstDouble = 5.99D;  // double number
            double mySecondDouble = 5.99d;  // double number
            double myThirdDouble = 5.99;  // double number // By default all fractional number are considered as DOUBLE
            Console.WriteLine("myFirstDouble : " + myFirstDouble);
            Console.WriteLine("mySecondDouble : " + mySecondDouble);
            Console.WriteLine("myThirdDouble : " + myThirdDouble);
            Console.WriteLine("double Range {0} - {1}", double.MinValue, double.MaxValue);
            Console.WriteLine("Size of double: {0}", sizeof(double));


            // Float Data Type
            // For float use 'f' as suffix
            float myFirstFloat = 3.7330645F;    // float number
            float mySecondFloat = 3.7330645f;   // float number
            // float myThirdFloat = 3.7330645;     // Warning due to type conversion from double to float
            Console.WriteLine("myFirstFloat : " + myFirstFloat);
            Console.WriteLine("mySecondFloat : " + mySecondFloat);
            // Console.WriteLine("myThirdFloat : " + myThirdFloat);
            Console.WriteLine("float Range {0} - {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Size of float: {0}", sizeof(float));


            // Char Data Type
            char myFirstChar = 'D';         // Character    // single charcter enclosed in single quotes
            // char mySecondChar = 'DD';         // Character    // multiple charcter enclosed in single quotes    // Warning
            //char myThirdChar = "DD";         // Character    // multiple charcters enclosed in double quotes    // Error
            Console.WriteLine("myFirstChar : " + myFirstChar);
            Console.WriteLine("char Range {0} - {1}", char.MaxValue, char.MaxValue);
            Console.WriteLine("Size of char: {0}", sizeof(char));


            // Boolean Data Type
            bool myTrueBool = true;         // Bool    
            bool myFalseBool = true;         // Bool    
            // bool myConfusedBool;         // Bool // UnInitialized    
            Console.WriteLine("myTrueBool : " + myTrueBool);
            Console.WriteLine("myFalseBool : " + myFalseBool);
            // Console.WriteLine("myConfusedBool : " + myConfusedBool); // Error - UnInitialized
            Console.WriteLine("bool Range {0} - {1}", bool.FalseString, bool.TrueString);
            Console.WriteLine("Size of bool: {0}", sizeof(bool));





            // String Data Type
            string myFirstText = "Hello";     // String
            string mySecondText = 'F'.ToString();         // Character to String Conversion
            string myThirdText = "F";         // String    
            string myFourthText;         // String // Only Declaration    
            myFourthText = "Hello Sir"; // Assignment
            Console.WriteLine("myFirstText : " + myFirstText);
            Console.WriteLine("mySecondText : " + mySecondText);
            Console.WriteLine("myThirdText : " + myThirdText);
            Console.WriteLine("myFourthText : " + myFourthText);
            // Console.WriteLine("Size of string: {0}", sizeof(string)); // not supported
            Console.WriteLine("Length of string: {0}", myFirstText.Length);


            // Decimal Data Type
            // For decimal use 'm' as suffix
            decimal myFirstDecimal = 3.7330645M;    // decimal number
            decimal mySecondDecimal = 3.7330645m;   // decimal number
            // decimal myThirdDecimal = 3.7330645;     // Warning due to type conversion from double to decimal
            // If the suffix m or M will not use then it is treated as double.
            Console.WriteLine("myFirstDecimal : " + myFirstDecimal);
            Console.WriteLine("mySecondDecimal : " + mySecondDecimal);
            // Console.WriteLine("myThirdDecimal : " + myThirdDecimal);
            Console.WriteLine("decimal Range {0} - {1}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("Size of decimal: {0}", sizeof(decimal));

            // Explonential Representation
            float exponentialFloat = 35e3F;     // 35 x 10^3 Float
            float negativeExponentialFloat = 35e-3F;     // 35 x 10^-3 Float
            double exponentialDouble = 12E4D;   // 12 x 10^4 Double
            Console.WriteLine("exponentialFloat : " + exponentialFloat);
            Console.WriteLine("negativeExponentialFloat : " + negativeExponentialFloat);
            Console.WriteLine("exponentialDouble : " + exponentialDouble);

            Console.ReadLine();
        }
        public static void Example()
        {
            CValueType.Example();
            CReferenceType.Example();
            CPointerType.Example();
            ArrayType.Example();
            AllTypeSummery();
        }
    }
}
