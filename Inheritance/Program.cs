using System.Numerics;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // dervied class has all properties of super class

            //Derived d = new Derived();
            //// Properties From Super Class 
            //d.MyProperty = 10; 
            //d.MyProperty1 = 20;
            //d.MyProperty2= 30;
            //// d.Method();  ==> protected method 

            //d.test(); // method of sub class 


            //clsDerived d = new clsDerived { MyName="test",MyAge=10,MyId="234143"};

            //MyName => super 
            //MyAge => super
            //MyId => property from dervied class

            // // UpCasting 
            // clsSuper s = d;

            // s.MyName = "Test"; // super 
            //s.MyAge = 10; // super
            //              //  s.MyId = "2323"; // property from dervied (you cannot access it as it is upcasted to super)

            // // DownCasting 
            // clsDerived d1 = (clsDerived)s; 
            // d1.MyId = "test";
            // d.MyName = "Test";
            // d.MyAge = 10;


            // Super s = new Super();
            // s.Print();
            // s.AnotherPrint(); // will call the default implementation in super class 

            //Derived d = new Derived();
            // d.Print();
            // d.AnotherPrint(); // will call the new implementation in sub class 

            // Console.WriteLine("shadowing_________");
            // Super s2 = d; // upcasting 
            // s2.AnotherPrint(); // will call the default implementation in super class 

            // Console.WriteLine("\nwithout shadowing_________");
            // s2.Print();

            Doctor d = new Doctor("ahmed",28,"2432","Nervous System",1000,"The Brain");

            d.Print();

            // Please Note That The Upcasting Will Print The Method Of
            // Base Class Not The Overriden Ver That Has Been Implemented In Derived Class ( Method Shadowing(hiding) ) / 

            // upcasting the doctor to employee
            Employee emp = d;
            Console.WriteLine("\n__________________________________________\n");

            emp.Print();


            // upcasting the employee to person

            Person p = emp;
            Console.WriteLine("\n__________________________________________\n");
            p.Print();  

        }

    }
}
