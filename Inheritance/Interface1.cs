using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal interface Interface1
    {
        // Interface Can Have Methods Without implementation (abstract methods)
        abstract void x();      void y();
        public int MyProperty { get; set; }
        public void K () // ==> you cann't call the implemented method in dervied class 
        {
            Console.WriteLine(c);

        }

        //Interface1() ==> interface cann't have constructors 
        //{

        //}

        static int c = 1; // you can have static data members :) lol i think it is available due to the new ver of lan 

        public static int b = 2;
        private static int a = 3;
        protected static int c2 = 4;

        // interface cannot have data members 
        //   int ty = 1; 

        public static void C(int i)
        {
        }


    }

    class C : Interface1
    {
        public void x() { }
        public void y() { Interface1.b=0;
            //K();
        }

        public int MyProperty { get; set; }


    }
}
