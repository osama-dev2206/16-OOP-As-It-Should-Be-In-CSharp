using System;
using System.Collections.Generic;
using System.Text;

namespace Static_class_Vs_Private_Constructor
{
    internal static class ClassStatic
    {
        public static int MyProperty { get; set; }
        public static string  MyProperty1 { get; set; }

                                                     // Static Constructor  // 
        // 1. You Can Set Access Modifier For The Static Constructor 

        //public static ClassStatic()
        //{ 
        //}

         static ClassStatic()
        {
        }

    }
}
