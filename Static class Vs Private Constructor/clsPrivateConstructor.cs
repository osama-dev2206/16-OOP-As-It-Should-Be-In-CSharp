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
        
        
        // Paramterless Constructor 
        private clsPrivateConstructor()
        {
            MyProperty = 1;
            MyProperty1= 2;
        }

        // Paramterized Constructor Constructor 
        private clsPrivateConstructor(int x1 , int x2)
        {
            MyProperty = x1;
            MyProperty1 = x2;
        }

        // for sure you can not use static to return the current object 
        private  clsPrivateConstructor ReturnTheCurrentObj()
        {
            return this; 
        }

        // you can create an object of this class (as the constructor is accessible in class scope) -private-
        // it is method member for sure you cann't call this method 
        public clsPrivateConstructor Obj()
        {
             clsPrivateConstructor obj = new clsPrivateConstructor(x1:10,x2:20);  // create an object of this class 
            return obj;
        }


    }

    // You Can not Inherit The Super Class If Its Constructor Is Private As When You Create An Object Of Sub
    // class It Calls The Constructor Of Super Class 

    /*
     CS0122: 'clsPrivateConstructor.clsPrivateConstructor()' is
    inaccessible due to its protection level
    */

    //class Sub : clsPrivateConstructor 
    //{

    //}

}
