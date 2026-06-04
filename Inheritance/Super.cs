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

        protected void Method()
        {

        }

        private void PriMethod() { }
    }

    // Derived Class is inherting all properties and method of super class 
    //SubClass 
   internal class Derived : Super
    {
        /// try to access Class1 (super class properties  & Methods)
       public  void test()
        {
            MyProperty = 1;
            MyProperty1 = 2; 
            MyProperty2 = 3;

            Method();

           //  PriMethod(); // you cann't access the private methods /  data members of super class
        }
    }


}
