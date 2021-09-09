using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandlingDemo
{
    class DirectoryDemo
    {
        static void Main(string[] args)
        {

            //CreateDir(path);
            string p = @"C:\Users\deore\Desktop\IBMSept1\C#Demos\FileHandlingDemo\FileHandlingDemo\bin\Debug\FileDemos";
            //IEnumerable<string> filelist=Directory.EnumerateDirectories(p);

            //IEnumerable<string> filelist=Directory.EnumerateFiles(p);

            //string[] filelist=Directory.GetFiles(p);
            //string root=Directory.GetDirectoryRoot(p);
            //            Console.WriteLine(root);

            DirectoryInfo info = new DirectoryInfo(p);
            info= Directory.GetParent(p);

            FileInfo[] Finfo;
            Finfo=info.GetFiles();
            Console.WriteLine("File Info");
            foreach (var item in Finfo)
            {
                Console.WriteLine("Name = " + item.FullName);
                Console.WriteLine("Extension=" + item.Extension);
                Console.WriteLine("Creation Time= " + item.CreationTime);
            }

            Console.WriteLine("--------------------");
            string[] drives=Directory.GetLogicalDrives();
            foreach (var item in drives)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----Drive Inof-----");
            DriveInfo dr = new DriveInfo("C");
            Console.WriteLine("Free sapce=" + dr.AvailableFreeSpace);
            
            Console.WriteLine("Drive Format= " + dr.DriveFormat);
            Console.WriteLine("Type= "  + dr.DriveType);
            Console.WriteLine("Name= " +  dr.Name);
            Console.WriteLine("Free space= " +  dr.TotalFreeSpace); ;


            //foreach (var item in filelist)
            //{
            //    Console.WriteLine(item);
            //}
            Console.Read();
        }

        private static void CreateDir()
        {
            string path = @"D:\Sulakshana\";
            Directory.CreateDirectory(path + "FileDemos");
            Console.WriteLine("Done");
        }
    }
}
