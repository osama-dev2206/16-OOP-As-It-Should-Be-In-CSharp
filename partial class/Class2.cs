using System;
using System.Collections.Generic;
using System.Text;

namespace partial_class
{
    internal partial class Person
    {
        public void PrintInfo()
        {
            Console.WriteLine("The Name Is: " +  FirstName+' '+LastName);
            Console.WriteLine("The Age Is: "+ Age );
            Console.WriteLine("The Id Is: " + this.Id);
        }

        public void SendEmail(string subject)
        {
            Console.WriteLine("Sent!");
        }

        public void PhoneCall()
        {
            Console.WriteLine("Calling............");
            Thread.Sleep(1000);
            Console.WriteLine("Call Was Done!");
        }


 



    }
}
