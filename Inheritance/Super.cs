using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
  public class Super
    {
        public int MyProperty { get; set; }
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Hello From Super Class"); 
        }

        public virtual void AnotherPrint()
        {
            Console.WriteLine("Hello From Super Class2");
        }

        private void PriMethod() { }
    }

    // Derived Class is inherting all properties and method of super class 
    //SubClass 
    internal class Derived : Super
    {
        /// try to access Class1 (super class properties  & Methods)
        public void test()
        {
            MyProperty = 1;
            MyProperty1 = 2;
            MyProperty2 = 3;
            //  PriMethod(); // you cann't access the private methods /  data members of super class
        }

           public override void  Print() // the same signuture of base class but different implementation (override)
            {
            Console.WriteLine("Hello From Sub Class");
            //base.Print(); /// to call the overriden method 
            }

        public new void AnotherPrint() // method hiding (shadowing)
        {
            Console.WriteLine("Hello From Sub Class2");
        }

    }


}
