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

        // 2. Static Constructor Can not Have Any Paramters ( must be parameterless )
        // static ClassStatic(int n)
        //{
        //    MyProperty = n; 
        //}


        // static paramterless CONSTRUCTOR 
        static ClassStatic()
        {
            // this.MyProperty = 10;  ==> you can not use this pointer with static class !

            /// Intialize the static data members of the class // 
            Console.WriteLine("Hello From Static Constructor");
            MyProperty = -1;
            MyProperty1 = "empty";
        }

        public static void print()
        {

        }
        // static constructor cann't be overloaded 
        //static ClassStatic()
        //{
      
        //}

    }
}
