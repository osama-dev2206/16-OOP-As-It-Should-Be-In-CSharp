using System;
using System.Collections.Generic;
using System.Text;

namespace partial_class
{
    internal partial class Person
    {
         public class Address
        {
            public sbyte StNum { get; set; }
            public string StName { get; set; }

            public Address(sbyte StNum , string StName)
            {
                this.StNum = StNum;
                this.StName = StName;
            }

            public void PrintAddress()
            {
                Console.WriteLine("The Address Name Is: "+ this.StNum);
                Console.WriteLine("The Address Num Is: "+ this.StName);
            }

        }




    }
}
