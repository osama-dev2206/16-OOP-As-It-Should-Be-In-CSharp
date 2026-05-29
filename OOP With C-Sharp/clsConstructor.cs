using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_With_C_Sharp
{
    internal class clsConstructor
    {
        // ctor ==> constructor 
        // prop ==> auto implemented properities 

        // Constructor is a special method that is called when you create an object of class 
         // this special method will be invoked when you create an object of this class
      //public  clsConstructor()// ==> Parameterless constructor 
      //  {
      //      id = String.Empty;
      //      age = 1;
      //      name = String.Empty;
      //  }

        // Paramterized Constructor 
        //public clsConstructor(string Id , string name , sbyte age)
        //{
        //    this.name = name;
        //    this .id = Id;
        //    this.age = age;
        //}

        public string id { get; set; }
        public string name  { get; set; }
        public sbyte age { get; set; }

    }

}
