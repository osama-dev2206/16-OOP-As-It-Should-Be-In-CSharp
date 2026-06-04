using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace OOP_With_C_Sharp
{

    internal class Person
    {
        // static data members are shared between all objects , call only on the class level 
        static readonly string Delmi = "#//#";
        static readonly string FileName = "persons.text"; // this property is on class level not object level as it is shared between all objects of this class 
        
        // Auto Implemented Properties 
        string Fname { get; set; }
        string Lname { get; set; }
        sbyte Age { get; set; }
        string UserName { get; set; }
        string Id { get; set; }
        string Password { get; set; }

        // Paramterized Constructor To Force User To Make A Proper Object with these arguments 
        public Person(string fname, string laname, sbyte age, string username, string id, string password)
        {
            // will call the property get
            Fname = fname;
            Lname = laname;
            Age = age;
            UserName = username;
            Id = id;
            this.Password = password;

            // anyone creates object from this class will write to file
            WriteToFile(); 
        }

        // Read,Write To File 
        private string RecordLine()
        {
            return (this.Fname + Delmi + this.Lname + Delmi + this.Age + Delmi + this.UserName + Delmi + this.Id + Delmi + this.Password);
        }

        private static Person ConvertLineToObj(string record)
        {
            List<string> Record = new List<string>();
            Record = record.Split(Delmi).ToList(); // split the record into list 

            return new Person(Record[0], Record[1], Convert.ToSByte(Record[2]), Record[3], Record[4], Record[5]);
        }

        private void WriteToFile()
        {
            File.WriteAllText(FileName, RecordLine() + "\n");
        }

        public static Person Find(string id)
        {
            Person Obj = null;
            foreach (string record in File.ReadAllLines(FileName))
            {
                Obj = ConvertLineToObj(record);
                if (Obj.Id == id) return Obj;
            }

            return null;
        }


        public static Person Find(string username, string password)
        {
            Person Obj = null;
            foreach (string record in File.ReadAllLines(FileName))
            {
                Obj = ConvertLineToObj(record);
                if (Obj.UserName == username && Obj.Password == password) return Obj;
            }

            return null;
        }


    }


    }
