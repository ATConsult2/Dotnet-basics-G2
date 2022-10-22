using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;   

namespace andestech.learning2022.krasn
{
    public delegate void GreetsHandler(string name, int importance);

    internal class Program
    {
        delegate void GreetsHandler(string name, int importance);

        static void SayHello(string name, int importance)
        {
            WriteLine($"Hello, {name}{new String('!', importance)}");
        }

        static void SayHi(string name, int importance) =>
                    WriteLine($"Hi, {name}{new String('!', importance)}");
        static void SayPrivet(string name, int importance) =>
                    WriteLine($"Привет, {name}{new String('!', importance)}");


        static void testGreetings(GreetsHandler greets, string name, int number=1)
        {
            greets(name, number);
        }

        static void Main(string[] args)
        {
            testGreetings(SayPrivet, "Andrei", 3);
            testGreetings(SayHi, "Peter", 5);

        }
    }
}
