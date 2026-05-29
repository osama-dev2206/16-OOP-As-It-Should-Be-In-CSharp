using System;
using System.Collections.Generic;
using System.Text;

namespace Static_class_Vs_Private_Constructor
{
    internal static class StaticClass
    {
       // public  int MyProperty0 { get; set; } ==> you can not make non-static data,method member in static class
       // as there is no constructor and you can not create an object of static class !
        public static int MyProperty { get; set; } // static data member 

        // Static classes cannot have instance constructors //
        //public StaticClass()
        //{
        //    MyProperty = 0;

        //}

        public static void  Method()
        {

        }

    }

    //        'Sub': cannot derive(inherit)  from static class 'StaticClass'    /// 
    //class Sub : StaticClass
    //{

    //}


}
