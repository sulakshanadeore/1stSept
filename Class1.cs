using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolyDemo
{

    public interface ICalculator:Vehicle
    {
         void add(int i, int j);
         void sub(int i, int j);
        void mul(int i, int j);
        void div(int i, int j);
        void per(int i, int j);

        

}

    public class StdCalci : ICalculator
    {
        public void add(int i, int j)
        {
            Console.WriteLine(i+j);
        }

        public void div(int i, int j)
        {
            Console.WriteLine(i/j);
        }

        public void mul(int i, int j)
        {
            Console.WriteLine(i*j);
        }

        public void per(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void sub(int i, int j)
        {
            Console.WriteLine(i-j);
        }
    }


    public class CustomCalci : ICalculator
    {
        public void add(int i, int j)
        {
            Console.WriteLine(i + j);
        }

        public void div(int i, int j)
        {
            Console.WriteLine(i / j);
        }

        public void mul(int i, int j)
        {
            Console.WriteLine(i * j);
        }

        public void per(int i, int j)
        {
            Console.WriteLine((i+j)/2);
        }

        public void sub(int i, int j)
        {
            Console.WriteLine(i - j);
        }
    }
}
