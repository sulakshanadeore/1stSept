using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsDelegatesLibrary;
namespace EventsDelegatesApp
{
    class PersonEvents
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.calories = 400;
            Person._Hunger += new EatDelegate(p.Eat);
            p.Walk();
            Console.Read();
        }
        
    }
}
