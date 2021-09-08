using System;


namespace CollectionsDemo
{
    class JaggedArrayDemo
    {
        static void Main(string[] args)
        {
            //jagged array --- array of array
            //1st Grade---10 stud---10
            //2md Grade----20 stud--20
            //3rd grade----5 stud---5
                                   //R--c
             int[][] arr = new int[3][];
            arr[0] = new int[5] {1,2,3,4,5 };
            arr[1] = new int[6] {10,20,30,40,50,60 };
            arr[2] = new int[3] {100,200,300 };

            foreach (int[] item in arr)
            {
                Console.WriteLine("Elements in item==" + item.Length); 
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine("-------------------");
            }
            Console.Read();
        }
    }
}
