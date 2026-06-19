using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_OLd_Ver
{


     public interface IGymPerson
    {
      string  FullName{  get; set;  }
        void Display();

        void CheckIn(string persontype);
     

    }

    abstract class Person : IGymPerson
    {
        public string FullName { set; get; }
        public void Display()
        {
            Console.WriteLine("The Name Is: ", FullName);
        }

        public void SendNotification(string message)
        {
            Console.WriteLine($"{message}");
        }

        public void CheckIn(string persontype)
        {
                Console.WriteLine($"{persontype.ToUpper()} Entered");
        }

    }
     interface IPayment
    {
        void PayingFees();
    }

     class Member : Person  , IPayment
    {
        public Member()
        {
            base.CheckIn("Member");
        }
        
        enum MembershipType : sbyte
        {
            Regular=1 
           , Premium=2 
        }

      
        public string MembershipID { get; set; }
     public void PayingFees() { Console.WriteLine("payed"); }

    }

}
