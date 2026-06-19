using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_OLd_Ver
{
    internal class Outer
        // Each Class Has Its Own Methods,Properties etc ... 
        // Inner Class Cannot Access Any Member (except static) From Outer Class - without object -
        // Inner Class Can Access Static Data Member/Method  Of Outer Class Even It Is Private 
        // Outer/Inner Class Cann't Acess Anything From Inner/Outer Class Without Object 
        // Outer Class Can Access Static Data Members Of Inner Class If It Is Public Only 
        // Outer Class Cannot Access Private Class Members Of Inner Class (If You Have Created An Object From Inner) 
        // Inner Class Can Access All Outer Class Members If You Have Created An Object From Outer Class 
    {
        // outer class properties 
       private int PrivateMyProperty { get; set; }
       private int PrivateMyProperty1 { get; set; }

        public int PublicMyProperty { get; set; }

        public void Method() { }
        int e = 10; 

        static void vv() { }

      private  static int m = 0; 
        protected static int m1 = 0;


       private class Inner
        {
            private static double PrivateStataicInner = 0;
            public   static double PublicStataicInner = 0; // static member outer cannot access it if it isn't public 
            private int PrivateInner { get; set; }
            public int PublicInner { get; set; }

            void Test()
            {
                // Inner Class Cann't Access  Method or Properties or data fileds  Anything From Outer Class 
                ///   PublicMyProperty = 10;
                //    Method();
                
                Outer.m = 10; // you can access the private static members from outer class even it is private 
                m1 = 2342; // you can access the private static members from outer class even it is protected 
                vv(); 
            }

            public void PassObjOtuer(  Outer obj) 
            {
                obj.PrivateMyProperty = 10;
                obj.PublicMyProperty = 23; 
            }
        }


        void s()
        {
            Inner.PublicStataicInner = 123.432343;
           // Inner.PrivateStaticInner = 1213; 

            Inner j = new Inner();
            j.PassObjOtuer(  this );  // access public method of Inner 
       
        }

    }
}
