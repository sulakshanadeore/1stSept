using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolyDemo
{
    public class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime BirthDate { get; set; }

        public string FullName
        {
            get
            {
                return Fname + Lname;
            }
        }


    }
}
