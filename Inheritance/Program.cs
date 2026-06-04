namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            // dervied class has all properties of super class

            Derived d = new Derived();
            // Properties From Super Class 
            d.MyProperty = 10; 
            d.MyProperty1 = 20;
            d.MyProperty2= 30;
            // d.Method();  ==> protected method 

            d.test(); // method of sub class 
        }


    }
}
