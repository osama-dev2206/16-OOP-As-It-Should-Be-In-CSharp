namespace Static_class_Vs_Private_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
              CS0122: 'clsPrivateConstructor.clsPrivateConstructor()' is
              naccessible due to its protection level 
            */

            //clsPrivateConstructor Priv = new clsPrivateConstructor(); // you can not make an object of this class


            //  StaticClass x = new StaticClass();

            //StaticClass.Method(); // static method 


            //  ClassStatic x = new ClassStatic();// you cannot create an instance of static class 

            // static constructor will be called once only !
            ClassStatic.MyProperty = 100;
            ClassStatic.MyProperty1 = "hello";
            Console.WriteLine(ClassStatic.MyProperty );


            Console.WriteLine(ClassStatic.MyProperty1);
            ClassStatic.print();


        }

    }
}
