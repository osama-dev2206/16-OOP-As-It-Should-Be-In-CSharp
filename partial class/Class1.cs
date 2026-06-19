using System;
using System.Collections.Generic;
using System.Text;

namespace partial_class
{
    internal partial class Person
    {
        public partial void Post() // Defination 
        {
            // implemetation 
            Console.WriteLine("HI Iam stub@");
            Contact();

        }

        private partial string Contact() { return " ;"; }

        partial void Delete()
        {

        }


    }
}
