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
        static void Main(string[] args)
        {
            Wire w1 = new Wire { Length = 10 };
            Wire w2 = new Wire { Length = 2 };

            Wire w3 = w2 + w1; //  operator  + !!
            WriteLine(w3);
            WriteLine(w2);
            w3++;
            w3++;
            WriteLine(w3);
            WriteLine("------------------------------");
            Wire w4 = Wire.Join(ref w1, ref w2);
            WriteLine(w4);
            WriteLine(w2);

        }
    }
}
