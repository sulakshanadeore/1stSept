using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLibrary
{
    
    public class Student
    {
        static int rollno = 0;
        int _rollno;
        string _sname;
        string _std;
        int s1, s2, s3,tmarks;

        public Student()
        {
            rollno += 1;
            Console.WriteLine("enter name");
            _sname = Console.ReadLine();

        }

        public Student(string sname,string grade)
        {
            rollno += 1;
            this._sname = sname;
            this._std = grade;
        }

        public void DisplayMarks()
        {
            Console.WriteLine("Rollno " + rollno);
            Console.WriteLine("Name of Student= " + _sname);
            Console.WriteLine("S1= " + s1);
            Console.WriteLine("S2= " + s2);
            Console.WriteLine("S3= " + s3);

        }


        public void AcceptMarks()
        {
            

            Console.WriteLine("Enter sub1 marks");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter sub2 marks");
            s2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter sub3 marks");
            s3 = Convert.ToInt32(Console.ReadLine());


        }

        public int TotalMarks { get { return tmarks; } }

        public void CalculateMarks()
        {
            //3 subjects---3 variables
            //3 times -- accept marks for 3 diff sub--read/write--properties
            //3 times----display for 3 different sub--read/write--properties
            tmarks=s1 + s2 + s3;
            Console.WriteLine(tmarks);
        }


    }
}
