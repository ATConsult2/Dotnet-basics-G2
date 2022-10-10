//using andestech.consulting2022.krasn.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.consulting2022.krasn
{
    internal class Program
    {
        static void testDebug() {
            WriteLine("Hi all from testDebug!!");
        }

        static void Main(string[] args)
        {
            WriteLine("Hi all!!");
            WriteLine("Hi all 2!!");
            testDebug();
            utils.TestDebug.testDebug();
            WriteLine("Hi all 3!!");

        }
    }
}
