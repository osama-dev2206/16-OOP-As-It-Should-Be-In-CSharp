using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class clsSuper
    {
        public string MyName { get; set; }
        public sbyte MyAge { get; set; }
    }

    class clsDerived : clsSuper
    {

        public string MyId { get; set; }
      

    }

}
