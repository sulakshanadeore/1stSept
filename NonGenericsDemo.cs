using System;
using System.Collections;


namespace CollectionsDemo
{
    class NonGenericsDemo
    {
        static void Main(string[] args)
        {
            //ArrayList,Stack,Queue,Hashtable
            //SortedList
            //Non-generic--- any type----- Object Type
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);

            //arrayList.Add(1.34f);
            //arrayList.Add(1234.353535d);
            //arrayList.Add("DSfsf");
            //arrayList.Add('a');
            //arrayList.Add(new DateTime());

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("afer insert .................");
            //arrayList.Insert(1, 100);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----Insert Range---");

            //int[] arr1 = new int[] { 34, 342, 33, 11, 22 };
            //Console.WriteLine();
            //arrayList.InsertRange(2, arr1);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------");
            //arrayList.Remove(34);
            //Console.WriteLine();
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-------------");
            //arrayList.RemoveAt(1);
            //Console.WriteLine();
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}



            //Hashtable h = new Hashtable();
            //h.Add(1, "A");
            //h.Add("1", "A");
            //h.Add("2", "C");
            //h.Add(3, "D");

            //IDictionaryEnumerator ie=h.GetEnumerator();
            //while (ie.MoveNext())
            //{
            //    Console.WriteLine(ie.Key + " "  + ie.Value);
            //}
            //Console.WriteLine("------------------");

            //Console.WriteLine("Using for each");
            //Console.WriteLine("----------------------");
            //foreach (DictionaryEntry item in h)
            //{
            //    Console.WriteLine(item.Key + "  " + item.Value);
            //}


            Stack s = new Stack();//LIFO + type is data is not known
            s.Push(34);
            s.Push(234.33f);
            s.Push("sdfsdf");
            s.Push('A');
            s.Push(new DateTime());

            s.Pop();//datetime
            s.Peek();//A
            s.Contains(34);

            Queue q = new Queue();//FIFO
            q.Enqueue(34);
            q.Enqueue(234.33f);
            q.Enqueue("sdfsdf");
            q.Enqueue('A');
            q.Enqueue(new DateTime());

            q.Dequeue();
            q.Peek();
            q.Contains(34);

            Console.WriteLine("Sorted Lsit");
            SortedList sorted = new SortedList();
            sorted.Add(3, 3);
            sorted.Add(2, 4);
            sorted.Add(11, "A55");
            IList ilist=sorted.GetKeyList();
            Console.WriteLine("IList");
            foreach (var item in ilist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------");



            foreach (DictionaryEntry item in sorted)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

           








            Console.Read();


        }
    }
}
