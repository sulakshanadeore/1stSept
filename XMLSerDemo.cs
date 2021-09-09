using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace SerializationDemo
{
    class XMLSerDemo
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("customer1.xml", FileMode.Create, FileAccess.Write);
            Customer c = new Customer();
            c.Custid = 1;
            c.CustName = "Aryan";
            c.CustCity = "Pune";
           // c.CustPwd = "abc@123";
            XmlSerializer serializer = new XmlSerializer(typeof(Customer));
            serializer.Serialize(fs, c);
            fs.Close();


        }
    }
}
