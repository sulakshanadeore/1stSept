using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingDemo
{
    class FilestreamTextDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. create 2. read 3. delete 4 exit 5.Append");
            int ch = Convert.ToInt32(Console.ReadLine());
            string p = @"C:\Users\deore\Desktop\IBMSept1\C#Demos\FileHandlingDemo\FileHandlingDemo\bin\Debug\FileDemos\";

            switch (ch)
            {
                case 1:
                       Console.WriteLine("enter fname");
                    string f = Console.ReadLine();
                    p=string.Concat(p, f);
                   
                    FileStream fs = new FileStream(p, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    Console.WriteLine("Enter contents");
                    string c = Console.ReadLine();
                    sw.Write(c);
                    sw.Close();
                    fs.Flush();
                    fs.Close();
                   
                    fs.Dispose();

                    break;
                case 2:
                    Console.WriteLine("enter fname");
                    f = Console.ReadLine();
                    p = string.Concat(p, f);

                    fs = new FileStream(p, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    Console.WriteLine(sr.ReadToEnd());
                    sr.Close();
                    fs.Flush();
                    fs.Close();
                    fs.Dispose();


                    break;
                case 3:
                    Console.WriteLine("enter fname");
                    f = Console.ReadLine();
                    p = string.Concat(p, f);
                    File.Delete(p);
                    break;
                case 4:
                    Environment.Exit(1);

                    break;
                case 5:
                    Console.WriteLine("enter fname");
                    f = Console.ReadLine();
                    p = string.Concat(p, f);

                    fs = new FileStream(p, FileMode.Append, FileAccess.Write);
                     sw = new StreamWriter(fs);
                    Console.WriteLine("Enter contents");
                    c = Console.ReadLine();
                    sw.Write(c);
                    sw.Close();
                    fs.Close();

                    break;
            }
        }
    }
}
