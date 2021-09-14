using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib
{
    public class Person
    {

        public string Fname { get; set; }
        public string Lname { get; set; }

        public DateTime BirthDate { get; set; }

        public int Age { get; set; }

        public void CalculateAge(DateTime bdate)
        {
            //DateTime d = Convert.ToDateTime(BirthDate);
            //int age = DateTime.Now.Year - d.Year;
            //Age = age;

            Age= DateTime.Now.Year - bdate.Year;

        }
    }
}
