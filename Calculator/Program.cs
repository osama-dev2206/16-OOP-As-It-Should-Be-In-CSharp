namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

         clsCalculator C = new clsCalculator();

            C.Add(10);
            C.PrintResult();

            C.Sub(2);
            C.PrintResult();

            Console.WriteLine($"\nThe Prev Value Is: {C.ThePrevValue}");
            Console.WriteLine($"The Prev Operation is:  {C.ThePrevOperation}");


            C.Multi(2);
            C.PrintResult();

            C.Div(0);
            C.PrintResult();

            C.Div(2);
            C.PrintResult();

            C.Clear();
            C.PrintResult();

        }

}
}
