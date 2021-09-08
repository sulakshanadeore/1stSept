using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemoEvents
{
    
    class Class1 : EventArgs
    {
        public static event Calculation _DoAddition;
        public static event Calculation _DoSubtraction;
        public static event showSquareRoot _showRoot;
        static void Main(string[] args)
        {
            
        MyClass c = new MyClass();
        _DoAddition=new Calculation(c.Add);
         _DoAddition.Invoke(10, 30);

            _DoSubtraction = new Calculation(c.Subtraction);
            _DoSubtraction(20, 5);

            int no1 = 100;
            _showRoot = new showSquareRoot(c.CalSquareRoot);
            int a=_showRoot(no1);
            Console.WriteLine(a);


            Console.Read();
        
      }



   

    }
}

