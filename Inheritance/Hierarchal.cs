using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // One Super Class Many SubClasses Of Inherit From The Same Class 
    internal class Hierarchal
    {
        public int MyProperty { get; set; }
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }

    class H1 : Hierarchal
    {
        public int MyProperty3 { get; set; }
    }

    class H2 : Hierarchal
    {
        public int MyProperty4 { get; set; }

    }
}
