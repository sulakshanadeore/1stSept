using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLibrary
{
    public class Employee
    {
        static int empcount = 0;
        int _empid,_deptno;
        string _ename;
        //int _deptno;

        public void AcceptData()
        {
            //Console.WriteLine("Enter employee id");
            //_empid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee name");
            _ename = Console.ReadLine();

            Console.WriteLine("Enter Deptno");
            _deptno = Convert.ToInt32(Console.ReadLine());


            empcount += 1;
            

        }

        public void DisplayData()
        {
            _empid = empcount;
            Console.WriteLine("Your employee id= " + _empid);
            Console.WriteLine(_empid);
            Console.WriteLine(_ename);
            Console.WriteLine(_deptno);
        }

    }
}
