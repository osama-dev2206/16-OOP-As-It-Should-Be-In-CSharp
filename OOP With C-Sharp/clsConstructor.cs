using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_With_C_Sharp
{
    internal class clsConstructor
    {
        // ctor ==> constructor 
        // prop ==> auto implemented properities 
        public string id { get; set; }
        public string name { get; set; }
        public sbyte age { get; set; }

        // Paramterless Constructor (overloaded)
        public clsConstructor()
        {
            this.age = 1;
            this.id = "1";
            this.name = "o";
        }

        // Parameterized Constructor 
        public clsConstructor(string name , string id , sbyte age )
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public void Print()
        {
            Console.WriteLine($"Name Is: {this.name}");
            Console.WriteLine($"Age Is: {this.age}");
            Console.WriteLine($"Id Is: {this.id}");
        }

    }

}
