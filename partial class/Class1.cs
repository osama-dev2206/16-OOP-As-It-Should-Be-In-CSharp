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

        // Compile Time Polymorphism 
        // ==> method overloading (we donot care about anything except the data type of parameters and num of them ) 
        void sum() { }
        int sum(int n) { return n;  }
        float sum(float n) { return n; }

        double sum(double n) { return n; }


    }
}
