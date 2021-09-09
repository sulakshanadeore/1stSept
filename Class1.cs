using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Calculator
    {
        public Calculator() { }
        private double _number;
        public double Number
        {
            get { return _number; } set { _number=value; }
        }
        public void Clear() {
            Console.WriteLine("cleared...");
        }
        private void DoClear() 
        {
            Number = 0;
            Console.WriteLine("Do clear called");

        }
        public double Add(double number) 
        {
            return number + number; 
        }
        public static double Pi { get { return 3.14d; } }
        public static double GetPi() {
            return Pi;
        }
    }
}
