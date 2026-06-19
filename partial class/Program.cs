namespace partial_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Person person1 = new Person(21, "12132", "Ahmed", "Mohamoud");
            person1.SendEmail("Hi!");
            person1.PrintInfo(); 

            Person.Address s = new Person.Address(2, "El Tharir Street ");

            s.PrintAddress();

            person1.Post();  

        }
    }
}
