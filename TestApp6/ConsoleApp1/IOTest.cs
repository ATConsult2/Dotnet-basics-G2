using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace andestech.learning2022.krasn
{
    internal class IOTest
    {

        static public void Main(string[] args)
        {
            //  DelegateTest.Main2(args);
            //  EventTest.Main2(args);
            //  ReflectionTest.Main2(args);

            File.WriteAllText("file1.txt",
                "Hello!\nПривет!\nЗдравствуй!\nSalute!\n",
                Encoding.UTF8);

            string[] lines =
                File.ReadAllLines("file1.txt", Encoding.UTF8);
            foreach(var line in lines) WriteLine(line);

        }
    }
}
