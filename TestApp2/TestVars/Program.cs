using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
   
    internal class Program
    {
        
        static void testIOConsole() {
            Write("Enter your name: ");
            string name = ReadLine();
            WriteLine($"Hello, {name}!!!");
            WriteLine(string.Format("Hi, {0}!",name));
        }

        static void makeCalculus()
        {
            //for (; ; )
            while(true)
            {

                Write("Enter 1st number: ");
                string n1 = ReadLine();
                
                Write("Enter 2nd number: ");
                string n2 = ReadLine();

                if (n1 == "x" || n2 == "x") { WriteLine("Thank you."); break; }

                byte b1;
                byte b2;

                // if (!(byte.TryParse(n1, out b1) && byte.TryParse(n2, out b2)))
                if (!byte.TryParse(n1, out b1) || !byte.TryParse(n2, out b2))
                {
                    b1 = b2 = 0;
                    WriteLine("Wrong number format!!");
                }

                // byte b1 = byte.Parse(n1);
                // byte b2 = byte.Parse(n2);
                byte result;
                checked
                {
                    result = (byte)(b1 + b2);
                }
                
                WriteLine($"{b1}+{b2} = {result}");
            }
        }


        static void Main(string[] args)
        {
           // testIOConsole();
           makeCalculus();
           // ReadKey();
        }
    }
}
