using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    public class ZeroException : Exception
    {
        public ZeroException() 
            : base() { }
        public ZeroException(string message) 
            : base(message) { }
    }
}
