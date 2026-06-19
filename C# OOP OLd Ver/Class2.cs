abstract class abPerson
{
    public sbyte Age { get; set; }
    public string  Name { get; set; }

    //  sealed modifier can only be used on a method that overrides a base class method. 
    public virtual  void PrintBasicDetails()
    {
        Console.WriteLine($"The Name Is : {this.Name}");
        Console.WriteLine($"The Aeg Is : {this.Age}");
    }

}

class Student : abPerson
{
    public sealed override void PrintBasicDetails()
    {
        base.PrintBasicDetails();
    }
}

class o : Student
{
    void lk()
    {
        base.PrintBasicDetails();
    }

                                       // method shadowing ==> you can use method hiding with selaed method
    public new void PrintBasicDetails()                                
      {
        Console.WriteLine(" dfff");
      }

    // Override // 
    //public   override void PrintBasicDetails()  ==>'o.PrintBasicDetails()': cannot override inherited member
    //                                              'Student.PrintBasicDetails()' because it is sealed
    //  {
    //      Console.WriteLine(" dfff");
    //  }

}
