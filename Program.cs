using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i=0, j=0, ans=0;
            Customer c = new Customer();

            try
            {
                Console.WriteLine("entr custid");
                c.Custid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(c.Custid);
                //Console.WriteLine("entr j");
                //j = Convert.ToInt32(Console.ReadLine());

                //ans = i / j;
                //Console.WriteLine(ans);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.Data);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.Data);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }
            catch (CustNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.Data);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }

            Console.Read();
        }
    }
}
