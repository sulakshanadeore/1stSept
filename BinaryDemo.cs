using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingDemo
{
    class BinaryDemo
    {
        static void Main(string[] args)
        {
            // BinaryFileCreation();
            BinaryFileRead();

            Console.Read();


        }

        private static void BinaryFileRead()
        {
            FileStream fs = new FileStream(@"C:\Users\deore\Desktop\IBMSept1\C#Demos\FileHandlingDemo\FileHandlingDemo\bin\Debug\FileDemos\filebin1.bin", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long l1 = br.ReadInt32();
            Console.WriteLine(l1);
            br.Close();
            fs.Close();
        }

        private static void BinaryFileCreation()
        {
            FileStream fs = new FileStream(@"C:\Users\deore\Desktop\IBMSept1\C#Demos\FileHandlingDemo\FileHandlingDemo\bin\Debug\FileDemos\filebin1.bin", FileMode.Create, FileAccess.Write);
            //.dat
            //.bin
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(23423424);
            bw.Close();
            fs.Close();
        }
    }
}
