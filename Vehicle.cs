using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolyDemo
{
    public enum VehType
    {
        Geared,
        NonGeared

    }

    //abstract---- inheritance--- -general to specific---
    //general --abstract
  public abstract  class Vehicle:ICalculator
    {
        //common
        public int NoOfwheels { get; set; }
        public string fuelType { get; set; }
        public int Average { get; set; }
        public int Speed { get; set; }
        public int RegNo { get; set; }

        public void add(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void div(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void mul(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void per(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void sub(int i, int j)
        {
            throw new NotImplementedException();
        }

        public VehType VehicleType(string type)
        {
            VehType t;
            if (type=="Geared")
            {
                t = VehType.Geared;
               // ConsoleColor.
            }
            else
            {
                t = VehType.NonGeared;
            }
            return t;
        }

        public abstract void VehName();
        

    }
    public class FourWheeler : Vehicle
    {
        public override void VehName()
        {
            throw new NotImplementedException();
        }
    }

    public class Alto : FourWheeler
    {

    }


    public class Bicycle : Vehicle
    {
        //specific
        public override void VehName()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Enter VehName");
            string vname = Console.ReadLine();
        }
    }

    public class ClassicBicycle:Bicycle
    {
        public override void VehName()
        {
            base.VehName();
        }
    }

    public class KidBicyle : Bicycle
    { }


    class MyClass : ICalculator
    {
        public void add(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void div(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void mul(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void per(int i, int j)
        {
            throw new NotImplementedException();
        }

        public void sub(int i, int j)
        {
            throw new NotImplementedException();
        }
    }


}
