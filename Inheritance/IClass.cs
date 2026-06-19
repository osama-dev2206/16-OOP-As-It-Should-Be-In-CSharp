using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{

    public interface IPerson
    {
        // All Method & Properties Are Public By Default In Interface 
        string FirstName { get; set; }
        string LastName { get; set; }

        void Introduce();
        void Print();

        string To_String();

        static int y = 10; // allowed in newer vers of c#


        // must be public or protected 
        protected abstract void ui();
    }


    class B : IPerson
    {
        void IPerson.ui()
        {
            throw new NotImplementedException();
        }
        string IPerson.FirstName { get; set;}
        string IPerson.LastName { get; set;}

        void IPerson.Introduce() 
            { }

        void IPerson.Print() { }


        string IPerson.To_String()
        { return "";  }

    }


    /// <summary>
    /// ///////////////////////////////////////////////////////////////////
    /// </summary>

    abstract class clsAbstract
    {
        static int y = 10; //abstract classes can have static ... 
        public clsAbstract() // constructor 
        {

        }
        public int MyProperty { get; set; }
        public void print() // method 
        {
            Console.WriteLine("     "); 
        }

        public abstract void met(); // abstract method you should implement it 

        int m = 10; // you can use data member in abstract class 
    }
    
    class x : clsAbstract
    {
       void f()
        {
            MyProperty++;  // property from abstract class 
            print(); 
        }

        public override void met() // implemented the abstract method 
        {
            throw new NotImplementedException();
        }

    }

}
