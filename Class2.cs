using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesLibrary
{
    public delegate void EatDelegate();

    public class Person : EventArgs
    {
        public static event EatDelegate _Hunger;
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public int calories { get; set; }
        public void Eat()
        {
            calories = 400;
            Console.WriteLine("Calories restored =" + calories);
        }

        public void Walk()
        {
            for (int i = 0; i <= 50; i = i + 10)
            {
                Console.WriteLine("walking");
                calories = i;
            }
            Console.WriteLine("Calories dropped to 50");
            if (calories <= 50)
            {
                _Hunger();

            }
        }

    }
}
