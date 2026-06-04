using System.Reflection.Metadata.Ecma335;

namespace OOP_With_C_Sharp
{
    internal class clsPerson
    {
        // data members of class 
        //string _FirstName = string.Empty;
        //string _LastName = string.Empty;
        //sbyte _Age;
        //static short _Id; 
        enum _enGender { male = 0, female = 1 };
        _enGender Gender;

        //// Constructor 
        public clsPerson()
        {
             Id++;
        }


        //// Propery Get & Set 
        //public string fname // property set && get 
        //{
        //    set { _FirstName = value; }
        //    get { return _FirstName; }
        //}

        //public string lname
        //{
        //    set { _LastName = value; }
        //    get{ return _LastName; }
        //}

        //public sbyte Age
        //{
        //    set
        //    { /// one of the benfits of set property you can make a vaildiation of the value you set 
        //        if (value > 0 && value < 100) _Age = value;
        //    }
        //    get { return _Age; }
        //}



        //// read only property (get property only) 
        //public short Id
        //{
        //    get { return _Id;  }
        //}

        // Auto Implemented Properties  
        // there aren't private data fields you can access the data member by get property only
        public string fname{ set; get; }
        public string lname { set; get; }
        public sbyte Age { set; get; }
        public static short Id { get; private set; } // you can edit the id value in the class scope only ! 

        public string Type // ===> i didn't use auto implemented properties as i want to make my own implementation for them 
        {
            set
            {
                if (value.ToLower() == "male") Gender = _enGender.male;
                else if (value.ToLower() == "female") Gender = _enGender.female;
            }
            get { return Gender.ToString(); }
        }

        public void PrintPersonDetails()
        {
            Console.WriteLine($"The First Name Is : {fname}\nThe Last Name Is: {lname}\nThe Full Name Is: {fname+' '+lname}\nThe Age Is: {Age}\nPerson's Id:{Id} ");
        }


        // Destructor is called implictly when the life time of object ends 
        // Destructor cann't have access modifier , parameters 
        ~clsPerson() // called implictly by GC 
        {
            Console.WriteLine("Hello iam destructor!");
        }

    }

}
