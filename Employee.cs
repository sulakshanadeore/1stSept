using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolyDemo
{
    public class Employee
    {
        public int Empid { get; set; }

        public DateTime JoiningDate { get; set; }

        public int Deptno { get; set; }

        public double Salary { get; set; }


        //Overloading-- return type not considered, methods are in teh same class/scope/same name-- diff number,type and sequence of params
        public double CalculateSalary(int bs,int ta,int da)
        {
            double totsal = bs + ta + da;
            Salary = totsal;
            return totsal;

        }
        
        public void CalculateSalary(int bs, int ta, float sa)
        {
            double totsal = bs + ta + sa;
            Salary = totsal;
        }

        public virtual void CalculateSalary(float bs, int ta, int da)
        {
            double totsal = bs + ta + da;
            Salary = totsal;
            Console.WriteLine("Employee class");
        }

        public  void CalculateSalary(float bs, int ta)
        {
            double totsal = bs + ta;
            Salary = totsal;
        }



    }
    public class Manager : Employee
    {
        public int NoOfEmployees { get; set; }

        public int Exp { get; set; }

        //hide the base class methods which has same signature 
        //as that of the derived class-- add "new" keyword to the 
        //derived class method
        public  new void CalculateSalary(float bs, int ta)
        {
            double sal = bs + (bs * .10) + ta;
            base.Salary = sal;

        }

        public override void CalculateSalary(float bs, int ta, int da)
        {
            double s = (bs+ ta+ da) + 200;
            base.Salary = s;
            Console.WriteLine("Manager class");
        }



    }
    public class SuperManager:Manager
    {
        public sealed override void CalculateSalary(float bs, int ta, int da)
        {
            double s1 = (bs + ta + da) + 1000;
            base.Salary = s1;
            Console.WriteLine("Super manager class");
        }
    }

    public class Director : SuperManager
    {
        public new void CalculateSalary(float bs, int ta, int da)
        {
            Console.WriteLine("From Driector class");
        }

    }


    
}
