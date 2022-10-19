using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;


namespace andestech.learning2022.krasn
{
    internal class Wire
    {
        public int Length {get;set;}

        public override string ToString()
        {
            return "Wire: " + Length;
        }

        public static Wire operator +(Wire w1, Wire w2)
        {
            return new Wire { Length = w1.Length + w2.Length };
        }

        public static Wire operator ++(Wire w1)
        {
            w1.Length++;  return w1;
        }

        public static Wire operator --(Wire w1)
        {
            w1.Length--;  return w1;
        }

        public static Wire Join (ref Wire w1, ref Wire w2)
        {
            Wire w3 = new Wire { Length = w1.Length + w2.Length };
            w1 = w2 = null;
            return w3; 
        }

    }
}
