using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //SerializeCustomer();
            DeSerializeCustomer();
            Console.Read();
        }

        private static void DeSerializeCustomer()
        {
            FileStream fs = new FileStream("custdata.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter binary = new BinaryFormatter();
            Customer c1 = (Customer)binary.Deserialize(fs);
            Console.WriteLine(c1.Custid);
            Console.WriteLine(c1.CustName);
            Console.WriteLine(c1.CustCity);
           // Console.WriteLine(c1.CustPwd);
        }

        private static void SerializeCustomer()
        {
            FileStream fs = new FileStream("custdata.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter binary = new BinaryFormatter();
            Customer c = new Customer();
            c.Custid = 1;
            c.CustName = "Aryan";
            c.CustCity = "Pune";
            //c.CustPwd = "abc@123";
            binary.Serialize(fs, c);
            Console.WriteLine("Done....");
            fs.Close();
        }
    }
}
