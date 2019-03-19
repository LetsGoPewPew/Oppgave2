using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Exceptions
{
    public class TooNegativeException : Exception
    {
        public TooNegativeException()
        {
        }

        public TooNegativeException(string message) : base(message)
        {
        }

        public TooNegativeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
