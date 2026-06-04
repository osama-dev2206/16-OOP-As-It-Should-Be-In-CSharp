using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // the type access of classes are internal 
    class Person // super class 
    {
        public string name { get; set; }
        public sbyte age { get; set; }
        public string Id { get; set; }

        public Person(string name, sbyte age, string id) // paramterized constructor   
        {
            this.name = name;
            this.age = age;
            Id = id;
        }

        public virtual void Print()
        {
            Console.WriteLine("The Name Is: " + this.name);
            Console.WriteLine("The Age Is: " + this.age);
            Console.WriteLine("The Id Is: " + this.Id);
        }

    }

    class Employee : Person
    {
        public string Department { get; set; }
        public double Salary { get; set; }

        // pass the required arguments to the base class to enable me to create an object of this class
        public Employee(string name, sbyte age, string id, string department, double salary) :
            base(name, age, id)
        {
            this.Department = department;
            this.Salary = salary;
        }

        // Method Shadowing 
        public new void Print()
        {
            base.Print();
            Console.WriteLine($"The Department is {this.Department}");
            Console.WriteLine($"The Salary Is: {this.Salary:c}");
        }

    }

    // This Class Inherits all properties form person & employee class 
    class Doctor : Employee
    {
        public string Heal { get; set; }

        public Doctor(string name, sbyte age, string id, string department, double salary, string Heal)
            : base(name, age, id, department, salary)
        {
            this.Heal = Heal;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"What Does He/She Do: {this.Department}");
        }


    }



}
