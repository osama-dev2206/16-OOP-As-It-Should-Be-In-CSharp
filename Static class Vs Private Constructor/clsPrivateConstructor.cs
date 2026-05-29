using System;
using System.Collections.Generic;
using System.Text;

namespace Static_class_Vs_Private_Constructor
{
    internal class clsPrivateConstructor
    {
        public int MyProperty { get; set; }
        public int MyProperty1 { get; set; }

        // You Can not Make An Object Of Class That Has Private Constructor 
        private clsPrivateConstructor()
        {
            MyProperty = 1;
            MyProperty1= 2;
        }

        // for sure you can not use static to return the current object 
        public  clsPrivateConstructor ReturnTheCurrentObj()
        {
            return this; 
        }

        // you can create an object of this 
        public clsPrivateConstructor Obj()
        {
             clsPrivateConstructor obj = new clsPrivateConstructor(); 
            return obj;
        }


    }


}
