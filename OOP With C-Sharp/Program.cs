using OOP_With_C_Sharp;
using System;
using System.Threading.Tasks.Dataflow;

class clsA
{
    public int x1; // public data member
    private int x2; // private data member
    protected int x3; // protected data member 

    public void print()
    {
        Console.WriteLine(x1);
    }

    // default access modifier is private
    void privateMethod() { }

    protected void protectedMethod() { }

}

class clsB : clsA  // dervied class of class A 
{
    void test()
    {
        protectedMethod();  // i could access it because iam the dervied class of the class which has this method 
        //   privateMethod(); inaccessible (because it is private method member )
        Console.WriteLine(x1); // i can access public data member in derived class
                               // Console.WriteLine(x2); // inaccessible (because it is private data member )
        Console.WriteLine(x3);  // i can access it because it is protected data member and iam dervied class of the super class that has this data member 
    }
}


internal class Program // you can not write any function or whatever in c# without class as it is pure oop like java 
{
    static void Main(string[] args) // entry point for the program 
    {
        //clsA A = new clsA();
        //A.x1=10; // i could access it in the main because its public data member
        ////A.x2=20 ; // i couldn't access it because it is private data member (accessible in the class scope only )
        //// A.x3 = 40; // i couldn't access this data member because it is protected data member (accessible only in the class which derive this class)

        //A.print(); // i could access it in the main because its public method member
        //           //A.privateMethod(); // i couldn't access it because it is private  method  member (accessible in the class scope only )

        //// A.protectedMethod(); i couldn't access it because it is protected  method  member (accessible in the class which inherits the current class)


        //clsB b = new clsB();
        //b.x1 = 90; // (data member from clsA ) accessible in the dervied class because i have inherited the class clsA and it is public data member , so you can access it 

        //b.print(); // (method from clsA) acccessible in derived class because it is public method in the super class
        //           // and i have inherited the class clsA , so i can access it 

        //// b.protectedMethod();  // you cann't access protected method although i have inherited it because
        //// protected is only accessible in the dervied class && the same class

        //// b.test(); // i couldn;t access it because it is private method 

        //Static s  = new Static();
        //Static s2 = new Static();

        //s.MethodMember();
        //s.y = 2;  // data member i could access it on the object level
        //// s.x = 29; // you cann't access it on object level because it is static data member 

        ///*if you want to access static method/variable you should call it on the class level not object level*/

        //Static.x = 100; // static data member is shared between all objects 
        //s.y = 1;
        //s2.y = 2;

        //s.MethodMember();
        //s2.MethodMember();

        //// s.StaticMethod(); ==>  you cann't access static methods through object , you can access it on the class level only 
        //// static method is shared between all objects 
        //Static.StaticMethod(); 


        //clsPerson person1 = new clsPerson(); // object/instance of clsPerson class 

        //// call the property set  
        //person1.fname = "jana";
        //person1.lname = "Ahmed";
        //person1.Age = 20;
        //person1.Type = "female";

        //// call the property get 
        //Console.WriteLine(person1.fname); 
        //Console.WriteLine(person1.lname);
        //Console.WriteLine(person1.Age.ToString());
        //Console.WriteLine(person1.Type);

        //Console.WriteLine();

        //person1.PrintPersonDetails();


        //clsPerson person2 = new clsPerson(); // object/instance of clsPerson class 

        //// call the property set  
        //person2.fname = "jana";
        //person2.lname = "Ahmed";
        //person2.Age = 20;
        //person2.Type = "female";

        //person2.PrintPersonDetails();   

        //Settings s = new s; // you can not make an instance of static class 

        //Console.WriteLine( Settings.FullDate);
        // Console.WriteLine(Settings.DayNumber);
        //Console.WriteLine( Settings.MonthNumber);

        // Settings.Path = @"sonds//hi//projects";
        // Console.WriteLine(Settings.Path);


        //  clsConstructor obj = new clsConstructor(Id:"24566",name:"mohammed",age:20); // ==> will call the paramterized  constructor 
        //clsConstructor obj = new clsConstructor(); // because i didn't implement any constructor , compiler will automatically invoke the default constructor to intialize the unintilized data members
        // Console.WriteLine($"Name : {obj.name}");
        //Console.WriteLine($"Age: {obj.age}");
        //Console.WriteLine($"Id : {obj.id}");

        Console.WriteLine("_________The Object Intilized By Paramterless Constructor_______");
        clsConstructor obj = new clsConstructor(); // will call the paramterless constructor 
        Console.WriteLine($"Name : {obj.name}");
        Console.WriteLine($"Age: {obj.age}");
        Console.WriteLine($"Id : {obj.id}");

        Console.WriteLine("_________The Object Intilized By Paramterized Constructor_______");
        clsConstructor obj2 = new clsConstructor("Jana","9090",22); // will call the paramterized constructor 
        Console.WriteLine($"Name : {obj2.name}");
        Console.WriteLine($"Age: {obj2.age}");
        Console.WriteLine($"Id : {obj2.id}");


    }
}

