using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
        static void testGreetings2(Action<string,int> greets, string name, int number = 1)
        {
            greets(name, number);
        }

        static GreetsHandler getGreetings(string greets)
        {
            switch (greets.ToLower().Trim())
            {
                case "hi": return SayHi;
                case "he": return SayHello;
                case "pr": return SayPrivet;
                default: return null;
            }

        }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("en-US");

            testGreetings(SayPrivet, "Andrei", 3);
            testGreetings(SayHi, "Peter", 5);
            WriteLine("-----------------");
            GreetsHandler gh = SayHello;
            gh += SayHi;
            gh += SayHi;
            gh += SayPrivet;
            testGreetings(gh, "Andrei");
            WriteLine("-----------------");
            gh -= SayHi;
            gh -= SayHi;
            testGreetings(gh, "Basil",2);
            testGreetings(getGreetings("pr"), "Таня", 3);

            WriteLine("++++++++++++++++++++");
            Action<string,int> agreets = SayHi;
            // var agreets2 = SayHi; // c#10
            agreets += SayPrivet;
            Action<string, int> salute =
            (mess,n) => WriteLine($"Салют, {mess}{new String('!', n)}");

            agreets += salute;
            testGreetings2(agreets, "Andrei", 2);
            WriteLine("++++++ Calculator +++++++++");

            Dictionary<string, Func<double, double, double>> calcMap =
                new Dictionary<string, Func<double, double, double>>()
                {
                    {"+", (a,b)=>a+b },
                    {"-", (a,b)=>a-b },
                    {"/", (a,b)=>a/b },
                    {"*", (a,b)=>a*b },
                    {"**",(a,b)=>Math.Pow(a,b) }
                };

            String[] data = new String[] {
            "1 + 33", "1.2 -   0.55", "2 * 5.5", " 3  ** 7"
            };

            foreach (string toCalc in data)
            {
                string[] parts = toCalc.Split( new String[] {" "}, 
                    StringSplitOptions.RemoveEmptyEntries);

                double a = double.Parse(parts[0]);
                double b = double.Parse(parts[2]);
                string key = parts[1];
                WriteLine($"{parts[0]} {parts[1]} {parts[2]} = {calcMap[key](a, b)}");


            }



        }
    }
}
