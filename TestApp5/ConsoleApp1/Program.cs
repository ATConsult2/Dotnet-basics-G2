using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace andestech.learning2022.krasn
{
    internal class Program
    {
        static void WireTest() {
            Wire w1 = new Wire { Length = 10 };
            Wire w2 = new Wire { Length = 2 };

            Wire w3 = w2 + w1; //  operator  + !!
            WriteLine(w3);
            WriteLine(w2);
            w3++;
            w3++;
            WriteLine(w3);
            WriteLine("------------------------------");
            Wire w5 = w2 * 5.5; //  operator  * !!
            WriteLine(w5);

            WriteLine("------------------------------");
            Wire w4 = Wire.Join(ref w1, ref w2);
            WriteLine(w4);
            WriteLine(w2);
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T c = a; a = b; b = c;
        }
        static void SwapTest() {
            Wire w1 = new Wire { Length = 1 };
            Wire w2 = new Wire { Length = 2 };
            WriteLine($"{w1} -- {w2}");
            Swap(ref w1, ref w2);
            WriteLine($"{w1} -- {w2}");

        }

        static double Sum<T>(params T[] arr)
               
        {
            if (typeof(T) == typeof(int)) { }
            double summa = 0;
            //double[] arr2 = arr.Cast<double>().ToArray<double>();
            object[] arr2 = CastArray<T>(arr);
            foreach (var v in arr2) summa += (double)v;

            return summa; 
        }

        static object[] CastArray<T>(T[] arr)
        {
            object[] arr2 = new object[arr.Length];
            for (int i = 0; i < arr.Length; i++) arr2[i] = (object)arr[i];
         return arr2;           
        
        }

        static void echoCollection(IEnumerable colls)
        {
            Write("{");
            foreach (var d in colls) Write(d + ", ");
            Write("\b\b}\n");
        }

        static void Main(string[] args)
        {
            //WireTest();
            //SwapTest();
            Container<int> c1 = new Container<int>(1);
            Container<string> c2 = new Container<string>("FFAA");
            Container<Wire> c3 = new Container<Wire>(new Wire {Length=1 });

            double[] darr = new double[] { .1, .023, .43, .3 };
            byte[] barr = new byte[] {1,33,44,128,3,1};

            // WriteLine(Sum<double>(darr) + " ------ " + Sum<byte>(barr)); // Coversion error
            // indexer test
            Box box = new Box(
                new Wire[] {
                new Wire { Length = 1 },
                new Wire { Length = 10 },
                new Wire { Length = 5 },
                });
            WriteLine(box.L);
            WriteLine(box[1]);

            // --- Collection Test ---
            ArrayList alist = new ArrayList(4) {1,2,3,"111", box, -20 };
            ArrayList alist2 = new ArrayList(4) { 1, 2, 3, -30, 10, 12 };
            echoCollection(alist2);
            alist2.Add(201);
            echoCollection(alist2);
            WriteLine(alist2[2]);
            WriteLine(alist2.Capacity + " ---- " + alist2.Count);
            alist2.AddRange(new ArrayList { -2, -10, -5 });
            WriteLine(alist2.Capacity + " ---- " + alist2.Count);
            echoCollection(alist2);

            // ------ LINQ --------
            var res = from int d in alist2
                      where d>1 || d<-20
                      orderby d descending
                      select d;

            echoCollection(res);
            EnumTest et = new EnumTest();
            foreach (string greets in et)  Write(greets + " --- ");
            WriteLine();
            foreach (string greets in et.GetEnumerator2()) Write(greets + " --- ");
            WriteLine(); WriteLine("---------------------");
            echoCollection(alist2);
            alist2.Sort(new MyCompare());
            //alist2.Sort();
            Array.Sort(barr, (x, y) => y - x);
            echoCollection(alist2);

            // ------------- Generic List ---------
            WriteLine(); WriteLine("---------------------");
            List<Wire> lst = new List<Wire>();
            lst.Add(new Wire() { Length = 1 });
            lst.Add(new Wire() { Length = 10 });
            lst.Add(new Wire() { Length = 4 });
            lst.Add(new Wire() { Length = 7 });
            echoCollection(lst);
            // var f1 = (a, b) => b.Length - a.Length; c# 10
            lst.Sort((a, b) => b.Length - a.Length);
            echoCollection(lst);
            var lst2 = lst.Where(a => a.Length > 1);
            echoCollection(lst2);

            var result = from wire in lst
                         where wire.Length >4
                         select wire;

            echoCollection(result);
            // ------------- Generic List ----------
            WriteLine(); WriteLine("---------------------");
            Stack<int> stack = new Stack<int>(10);
            stack.Push(11);
            stack.Push(21);
            stack.Push(31);
            echoCollection(stack);
            stack.Pop();
            echoCollection(stack);
            WriteLine("---------------------");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(11);
            queue.Enqueue(21);
            queue.Enqueue(31);
            echoCollection(queue);
            queue.Dequeue();
            echoCollection(queue);

            WriteLine("---------------------");
            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {1, "Hi!" },
                {10, "Hello!" },
                { -2, "Salute!"}
            };

            dict.Add(3, "Привет!");
            dict[-2] = "Salute!!!";

            foreach (int key in dict.Keys) WriteLine(key + " ---> " + dict[key]);
            WriteLine("---------------------");
            var dict2 = dict.OrderBy(x => Math.Abs(x.Key)).
                ToDictionary(x => x.Key,v => v.Value);
            foreach (int key in dict2.Keys) WriteLine(key + " ---> " + dict2[key]);

        }

    }

    class MyCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            return Math.Abs((int)x) - Math.Abs((int)y);
        }
    }

    class EnumTest {

        public IEnumerator<string> GetEnumerator()
        {
            yield return "Hi!";
            yield return "Hello!!";
            yield return "Salute!!";
          //....

        }


        public IEnumerable<string> GetEnumerator2()
        {
            string[] greets = new string[] { "Hi!", "Hello!!", "Salute!!", "Привет!!" };

            foreach (string greet in greets) yield return greet;
            //....

        }

    }
}
