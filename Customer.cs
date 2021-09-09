using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    [Serializable()]
    public class Customer
    {
        public int Custid { get; set; }
        public string CustName { get; set; }
        public string CustCity { get; set; }
        [NonSerialized()]
        private string _custpwd;
        private string CustPwd
        {
            get
            {
                return _custpwd;
            }
            set
            {
                _custpwd = value;
            }
        }





    }
}
