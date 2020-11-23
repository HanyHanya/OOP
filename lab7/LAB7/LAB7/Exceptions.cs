using System;
using System.Collections.Generic;
using System.Text;

namespace LAB7
{
  
        public class InvalidNumberException : ArithmeticException
        {
            public int value { get; }
            public InvalidNumberException(string message, int val) : base(message)
            {
                value = val;
            }
        }

    public class InvalidNameException : ApplicationException
    {
        public InvalidNameException(string message) : base(message)
        {

        }
    }

    public class YearException : ApplicationException
    {
        public YearException(string message) : base(message)
        {

        }
    }

    public class NullReferenceException : SystemException
    {
        public NullReferenceException(string message) : base(message)
        {

        }
    }
}
