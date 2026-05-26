using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class clsCalculator
    {
        enum _enOperation:SByte{Add=1,Sub=2,Multi=3,Div=4}; // enum of operations
        _enOperation  ? _CurrentOp;  // instance of enum used to track operations (nullable)

        private  int ?  _Value {set;  get; } // data member used to make operations on it (auto implemented set , get ) 

        public int ?TheLastValue { private set;  get; }

        public void PrintResult() { Console.WriteLine(_Value);   Console.WriteLine("The Last Operation Was: {0}", _CurrentOp.ToString()); }

        public void Add(int value)
        {
            TheLastValue = _Value;
            _Value += value;
            _CurrentOp = _enOperation.Add;
        }

        public void Sub(int value)
        {
            TheLastValue = _Value; // save the current value  as prev 
            _Value -= value; // set the new value 
            
            _CurrentOp = _enOperation.Sub;
        }

        public void Multi(int value)
        {
            TheLastValue = _Value; // save the current value  as prev 
            _Value *= value; // set the new value 

            _CurrentOp = _enOperation.Multi;
        }

        public void Div(int value)
        {
            TheLastValue = _Value; // save the current value  as prev 

            if (value != 0)
            {
                _Value /= value; // set the new value 
                _CurrentOp = _enOperation.Sub;
            }

        }

      public  void Clear()
        {
            _Value = null;
            _CurrentOp = null;
            TheLastValue = null; 
        }


    }
}
