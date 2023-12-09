﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application.Types.ValueTypes;
using Application.Types.ReferenceType;
using Application.Types.PointerType;

namespace Application.Types
{
    class CTypes
    {
        /*
         * The variables in C#, are categorized into the following types −
         * 1) Value types -> Value type variables can be assigned a value directly
         * 2) Reference types -> The reference types do not contain the actual data stored in a variable, but they contain a reference to the variables
         * 3) Pointer types -> Pointer type variables store the memory address of another type.
         */

        static void Example()
        {
            CValueType.Example();
            CReferenceType.Example();
            CPointerType.Example();
        }
    }
}
