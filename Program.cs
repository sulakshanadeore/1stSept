using System;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 2111,31,11,15,61};

            int[] arr1 = new int[] { 2, 3, 11, 5, 6 };
            int[] arr2 = new int[5];
            arr2[0] = 10;
            arr2[1] = 20;
            arr2[2] = 2340;
            arr2[3] = 40;
            arr2[4] = 30;
            //Array
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //var -will implicitly understand
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");
            Array.Clear(arr, 2, 3);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            int len=arr.Length;
            Console.WriteLine("Length=  " + len);
            Console.WriteLine("---------------");
            int[] copyarr = new int[arr.Length];
            arr.CopyTo(copyarr, 0);
            Console.WriteLine("Copied arr");
            foreach (var item in copyarr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=---------");
            Array.Clear(copyarr,0,5);
            foreach (var item in copyarr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------");
            Array.Copy(arr, copyarr, 5);
            

            foreach (var item in copyarr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");

            Array.Copy(arr2, 0, copyarr, 0, 2);
            foreach (var item in copyarr)
            {
                Console.WriteLine(item);
            }
            Console.Read();



        }
    }
}
