using System;
using System.Collections.Generic;
using System.Text;

namespace partial_class
{
    internal partial class Person
    {
        public sbyte Age { get; set; }
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Person(sbyte age, string id, string firstName, string lastName)
        {
            Age = age;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        //1. partial method can be any return type 
        //2. partial method can be defined only in partial class 
     private  partial string Contact(); // ==> cannot be accessed outside class as it is private btw ! 

       public  partial void Post(); // declaration of partial method 

        partial void Delete();

    }
}
