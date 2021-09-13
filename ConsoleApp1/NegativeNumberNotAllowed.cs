using System;
using System.Collections.Generic;
using System.Text;

namespace TestingOfAddMethod
{
    public class NegativeNumberNotAllowed : Exception
    {
        public NegativeNumberNotAllowed(string message) : base(message)
        {

        }
    }
}
