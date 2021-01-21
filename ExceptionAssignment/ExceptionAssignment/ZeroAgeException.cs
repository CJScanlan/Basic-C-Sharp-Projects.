using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    public class ZeroAgeException : Exception
    {
        public ZeroAgeException()
            : base() { }
        public ZeroAgeException(string message)
            : base(message) { }
    }
}
