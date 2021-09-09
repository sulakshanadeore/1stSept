using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace SerializationDemo
{
    class JsonDemo
    {
        static void Main(string[] args)
        {
            //JsonSerialize();
            FileStream fs = new FileStream("customerdata.json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string c=sr.ReadToEnd();
            sr.Close();
            fs.Close();
            Customer s1=JsonConvert.DeserializeObject<Customer>(c);
            Console.WriteLine(s1.Custid);
            Console.WriteLine(s1.CustName);
            Console.WriteLine(s1.CustCity);
            Console.Read();


        }

        private static void JsonSerialize()
        {
            FileStream fs = new FileStream("customerdata.json", FileMode.Create, FileAccess.Write);


            Customer c = new Customer();
            c.Custid = 1;
            c.CustName = "Aryan";
            c.CustCity = "Pune";

            string s1 = JsonConvert.SerializeObject(c);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(s1);
            sw.Close();
            fs.Close();
        }
    }
}
