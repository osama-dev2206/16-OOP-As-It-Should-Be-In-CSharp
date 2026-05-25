using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_With_C_Sharp
{
    // internal access modifier accessible in the same assembly 
    internal class Static
    {
        public static int x; // you can access it on the class level only not object level , it is shared between all objects 
        public int y;

        // method member can access static data member s
        public void MethodMember()
        {
            Console.WriteLine();
            Console.WriteLine("the static member  is {0} ", x); // you can access static data member in non-static method
            Console.WriteLine("the non-static data member is : {0}",y);
        }

        public static void StaticMethod()
        {
            // Console.WriteLine(y);  // static method can not have non static data member
            Console.WriteLine("\nStatic Data Member(you can access it only on the class level) : {0}",x); // static method should have static variables only 
        }

    }
}
