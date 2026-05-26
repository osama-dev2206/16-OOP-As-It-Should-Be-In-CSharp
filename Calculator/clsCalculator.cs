using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class clsCalculator
    {
         enum _enOperation:SByte{Add=1,Sub=2,Multi=3,Div=4}; // enum of operations
        _enOperation  ? _CurrentOp;  // instance of enum used to track operations (nullable)
        _enOperation? _ThePrevOperation;

        private  int ?  _Value {set;  get; } // data member used to make operations on it (auto implemented set , get ) 

        public int ?ThePrevValue { private set;  get; }

        public void PrintResult() {
            Console.WriteLine(); 

            if (!IsNullValue()) 
                Console.WriteLine($"The Result Is = {_Value}");
            else Console.WriteLine("ERROR");

            if (_CurrentOp.HasValue) Console.WriteLine("The Last Operation Was: {0}", _CurrentOp.ToString());
            else Console.WriteLine("Invalid Operation ! \a");
        }

        public string? ThePrevOperation {
            get { return _ThePrevOperation.ToString(); }
        }

        private bool IsNullValue()
        {
            return ( !_Value.HasValue );
        }

        private void RemoveNullFromValue()
        {
            _Value = _Value.GetValueOrDefault();
        }

        public void Add(int value)
        {
            ThePrevValue = _Value;
            _ThePrevOperation = _CurrentOp;

            if (IsNullValue()) RemoveNullFromValue();
             _Value += value;
            _CurrentOp = _enOperation.Add;
        }

        public void Sub(int value)
        {
            ThePrevValue = _Value; // save the current value  as prev 
            _ThePrevOperation = _CurrentOp;

            if (IsNullValue()) RemoveNullFromValue();
            _Value -= value; // set the new value 
            
            _CurrentOp = _enOperation.Sub;
        }

        public void Multi(int value)
        {
            ThePrevValue = _Value; // save the current value  as prev 
            _ThePrevOperation = _CurrentOp;

            if (IsNullValue()) RemoveNullFromValue();
            _Value *= value; // set the new value 

            _CurrentOp = _enOperation.Multi;
        }

        public void Div(int value)
        {
            ThePrevValue = _Value; // save the current value  as prev 
            _ThePrevOperation = _CurrentOp;

            if (value != 0)
            {
                if (IsNullValue()) RemoveNullFromValue();
                _Value /= value; // set the new value 
                _CurrentOp = _enOperation.Sub;
            }
            else
            {
                _CurrentOp = null; 
            }

        }

      public  void Clear()
        {
            _Value = null;
            _ThePrevOperation =null;
            _CurrentOp = null;
            ThePrevValue = null; 
        }


    }
}
