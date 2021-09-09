using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Customer
    {
        int _custid;
        public int Custid { get { return _custid; } set {
                if (value<=0)
                {
                    throw new CustNotFoundException("Not found");
                }
                else
                {
                    _custid = value;
                }

            }

        }
    }


    [Serializable]
    public class CustNotFoundException : Exception
    {
        public CustNotFoundException() { }
        public CustNotFoundException(string message) : base(message) { }
        public CustNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected CustNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
