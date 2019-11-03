using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    class  Exception_IsFull: Exception
    {
        public Exception_IsFull(string message) : base(message)
        {
            
        }

    }
    class Exception_weight : Exception
    {
        public Exception_weight(string message) : base(message)
        {
            
        }
    }
    class Exception_age : Exception
    {
        public Exception_age(string message) : base(message)
        {
            
        }
    }
}
