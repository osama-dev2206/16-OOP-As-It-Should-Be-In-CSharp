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
        clsA A = new clsA();
        A.x1=10; // i could access it in the main because its public data member
        //A.x2=20 ; // i couldn't access it because it is private data member (accessible in the class scope only )
        // A.x3 = 40; // i couldn't access this data member because it is protected data member (accessible only in the class which derive this class)

        A.print(); // i could access it in the main because its public method member
                   //A.privateMethod(); // i couldn't access it because it is private  method  member (accessible in the class scope only )

        // A.protectedMethod(); i couldn't access it because it is protected  method  member (accessible in the class which inherits the current class)




    }
}

