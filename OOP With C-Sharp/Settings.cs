using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OOP_With_C_Sharp
{
    internal static class Settings // => you cannot make an object of static class 
    {
        // in static class you can not make non-static method 
        // public void Hi() { } ==> compilation error 
        static int x = 10;  // data members should be static also in static class 

        /// <summary>
        ///  Static Properties 
        /// </summary>
        public static int DayNumber
        {
            get
            {
                return DateTime.Now.Day;
             }

        }

        public static int MonthNumber
            {
            get
            {
                return DateTime.Now.Month;
            }
        }

        public static string FullDate
        { get { return DateTime.Now.Date.ToString(); } }

        public static string  Path{ set; get; } // auto implemented property 

    }
}
