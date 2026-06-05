using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace Inheritance
{
    // Abatract class cann't be instanitied you must inherit it to create an object , abstract class contains
    // abstract methods , normal methods(with its implementation)
    // abstract method => method that has a defination without implementation
    // Abstract Class Is Used To Create The Core Identity Of Class
    public abstract class  abPerson
    {
        // Abstract Class Can Have Different Types Of Access Modifiers(public,private,protecred) // 
        public string Name { get; set; }


        static int count = 0; // static class can have fields

        //Abstract Class Can Have Declaration And Implementation Parts 
        public virtual void Print()
        {
            Console.WriteLine("The Name Is: ", Name);
           
        }

        //abstract method doesn't contain implementation & it should be public 
       public abstract void SendEmail(string SendToEmail);


        //Abstract Class Can Have Constructor 
        public abPerson(string name) // altough there is constructor you cann't make an instance of this class 
        {
            this.Name = name;
            
        }


        // Abstract Class Can Have Static Methods 
        public static void SendEmail(string from , string to ,string subject )
        {
            Console.WriteLine($"The Email Is From {from} and will be sent to {to} its subject is {subject}");
        }

        private void gg(string s) { Console.WriteLine();  }
    }

    class clsEmployee : abPerson
    {
        public string Id { get; set; }

        public clsEmployee(string name , string id) : base(name)
        {
            this.Id = Id; 
        }

        // You Will Not Able To Make An Object Of This Class If You Didn't Implement The Abstract Methods 
       public override void  SendEmail(string SendTo)
        {
            Console.WriteLine("Email Will Be Sent To : ", SendTo);
        }


        public override void Print()
        {
            base.Print();
            Console.WriteLine("The ID Is: ", Id);
        }



    }

}
