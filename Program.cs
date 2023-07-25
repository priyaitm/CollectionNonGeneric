using System;
using System.Collections;

namespace Collection1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            Console.WriteLine("............................ArrayList..........................");

            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);

            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200);
            al.Add(300);
            al.Add(400);


            al.Insert(3, 56);

            al.Remove(200);
            al.RemoveAt(1);

            foreach (object obj in al)
            {

                Console.WriteLine(obj);
            }
           
           

            Console.WriteLine("............................Hashtable..........................");
            // Hashtable  ( Array and ArrayList)

            Hashtable ht = new Hashtable();

            ht.Add("Eid", 101);
            ht.Add("Name", "Ankush");
            ht.Add("Email", "ankush435@gamil.com");
            ht.Add("location", "Mumbai");



            foreach (Object key in ht.Keys)
            {
                Console.WriteLine(key + ":" + ht[key]);
            }
            


            Console.WriteLine("............................Stack..........................");

            // stack
            Stack st = new Stack();

            st.Push(28);
            st.Push(54);
            st.Push(4.89f);
            st.Push("Anuradha");

            foreach (object obj in st)
            {

                Console.WriteLine(obj);
            }

            Console.WriteLine("............................shortedList..........................");

            SortedList sl = new SortedList();

            sl.Add("or", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");


            foreach (Object key in sl.Keys)
            {
                Console.WriteLine(key + ":" + sl[key]);
            }


            //Queue
            Console.WriteLine(".........................Queue............................");

            Queue q = new Queue();
            q.Enqueue("67");
            q.Enqueue("89");
            q.Enqueue("3676.8");
            q.Enqueue("Anu");

            foreach (object obj in q)
            {
                Console.WriteLine(obj);
            }


            Console.ReadLine();
        }
}

}
