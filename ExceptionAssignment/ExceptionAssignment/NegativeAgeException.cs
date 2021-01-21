using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    public class NegativeAgeException : Exception
    {
        public NegativeAgeException()
            : base() { }
        public NegativeAgeException(string message)
            : base(message) { }
    }
}
