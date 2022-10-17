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
            Singleton s1 = Singleton.getInstance();
            s1 = Singleton.getInstance();
            s1 = Singleton.getInstance();
        }
    }
}
