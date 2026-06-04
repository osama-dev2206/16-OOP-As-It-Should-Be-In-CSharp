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


            Super s = new Super();
            s.Print();

           Derived d = new Derived();
            d.Print();
        }


    }
}
