namespace OOP_With_C_Sharp
{
    internal class clsPerson
    {
        // data members of class 
        public string fname;
        public sbyte age;
        public string lname;

        public void Print()
        {
            Console.WriteLine($"First name : {fname}\nLast name : {lname}\nAge : {age} ");
        }

    }
}
