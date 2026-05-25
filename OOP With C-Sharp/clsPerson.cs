using System.Reflection.Metadata.Ecma335;

namespace OOP_With_C_Sharp
{
    internal class clsPerson
    {
        // data members of class 
        string _FirstName = string.Empty;
        string _LastName = string.Empty;
        sbyte _Age;
        enum _enGender { male = 0, female = 1 };
        _enGender Gender;

        // Propery Get & Set 
        public string fname // property set && get 
        {
            set { _FirstName = value; }
            get { return _FirstName; }
        }

        public string lname
        {
            set { _LastName = value; }
            get{ return _LastName; }
        }

        public sbyte Age
        {
            set
            { /// one of the benfits of set property you can make a vaildiation of the value you set 
                if (value > 0 && value < 100) _Age = value;
            }
            get { return _Age; }
        }

        public string Type
        {
            set {
                if (value.ToLower() == "male") Gender = _enGender.male;
                else if (value.ToLower() == "female") Gender = _enGender.female;
            }
            get { return Gender.ToString(); }
        }

    
    

    public void PrintPesonDetails()
        {
            Console.WriteLine($"The First Name Is : {fname}\nThe Last Name Is: {lname}\nThe Full Name Is: {fname+lname}\nThe Age Is: {Age}");
        }

    }

}
