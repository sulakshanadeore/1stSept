using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLibrary
{
    public class Employee
    {
        //variables
        static int empcount;
        int _empid,_deptno;
        string _ename;
        //int _deptno;

        static Employee()
        {
            //static constructor doesn't have access specifier
            //it is called BEFORE the first object gets created.
            //its only called ONCE in the lifetime of the class
            //its used to initialize variables in the class
            //connection initializations are done in the static constructor.
            Console.WriteLine("Static constructor called");
            empcount = 0;
            Console.WriteLine("currently no employees... Empcount = " + empcount );
        }

            //ctor + tab twice
        public Employee()
        {
            Console.WriteLine("Default constructor...");
            empcount += 1;
        }

        //constructors with parameters are called parameterised constructors
        public Employee(int empid,string ename,int deptno)
        {
            empcount += 1;
            _empid = empid;
            _ename = ename;
            _deptno = deptno;
            //this._empid = empid;
            //this._ename = ename;
            //this._deptno = deptno;
        }

        public void AcceptData()
        {
            //Console.WriteLine("Enter employee id");
            //_empid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee name");
            _ename = Console.ReadLine();

            Console.WriteLine("Enter Deptno");
            _deptno = Convert.ToInt32(Console.ReadLine());


            //empcount += 1;
            

        }

        public void DisplayData()
        {
            //_empid = empcount;
            Console.WriteLine("Your employee id= " + _empid);
            Console.WriteLine(_empid);
            Console.WriteLine(_ename);
            Console.WriteLine(_deptno);
        }

    }
}
