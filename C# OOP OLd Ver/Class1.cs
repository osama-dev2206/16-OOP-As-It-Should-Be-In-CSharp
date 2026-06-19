using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_OLd_Ver
{
    // interface ==> defines the class abilities 
    public interface iPerson
    {
     
        string Name { set;  get; }
        sbyte Age { set; get; }

        string Id {  set; get; }
        
    }

    public interface iCommunicate
    {

      void SendEmail(string email); // abstract 
        void SendSms(string message); // abstract 

        void Call(); // abstract 

    }

    internal class Class1 : iPerson , iCommunicate // class that inherits multiple intefaces ( please note c# still doesn't support multiple inheritance 
    {
        void iCommunicate.Call()
        {
            throw new NotImplementedException();
        }

        void iCommunicate.SendEmail(string content)
        {
            throw new NotImplementedException();
        }

        void iCommunicate.SendSms(string message)
        {
            throw new NotImplementedException();
        }


        string iPerson.Name { set; get; }
        string iPerson.Id { set; get; }
        public sbyte Age { set; get; }

    }
}
