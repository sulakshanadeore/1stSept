using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHandlingLib;
using System.Windows.Forms;

using System.IO;
namespace FileHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserFileCreation fileCreation = new UserFileCreation();
            Console.WriteLine("Enter choice 1 .create 2 copy 3 delete 4.move");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:

                    Console.WriteLine("Enter File Name ");
                    string path = Console.ReadLine();
                    string a;
                    Console.WriteLine("Enter File Contents");
                    a = Console.ReadLine();
                    //bool ans = fileCreation.Create(path);

                    //File.Create(path);
                    //File.WriteAllLines();
                    //File.WriteAllText(path, a);

                    break;

                case 2:
                    Console.WriteLine("Enter source file name");

                     path = Console.ReadLine();
                    Console.WriteLine("Enter dest file name");
                    string destpath = Console.ReadLine();
                    File.Copy(path, destpath);
                    break;

                case 3:
                    Console.WriteLine("Enter file naem");
                    path = Console.ReadLine();
                    File.Delete(path);
                    break;

                case 4:


                    Console.WriteLine("Enter source file name");

                    path = Console.ReadLine();

                    destpath= @"C:\Users\deore\Desktop\IBMSept1\C#Demos\FileHandlingDemo\FileHandlingDemo\obj\Debug\";
                    Console.WriteLine("Enter dest file name");
                    //FolderBrowserDialog f = new FolderBrowserDialog();
                    //DialogResult dr = f.ShowDialog();
                    string p = Console.ReadLine();
                    destpath=string.Concat(destpath, p);
                    //if (dr==DialogResult.OK)
                    //{
                        File.Move(path,destpath);
                    //}
                   
                    break;
                default:
                    break;
            }


            

            
            
            Console.Read();



        }
    }
}
