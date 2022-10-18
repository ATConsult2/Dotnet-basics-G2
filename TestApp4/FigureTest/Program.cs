using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using andestech.learning2022.krasn.geom;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
           // System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.;
            Circle circle = new Circle 
            { R = 10, PointXY = new Point { X = 1, Y = 2 } };
            WriteLine(circle);
          //  WriteLine(String.Format("{0:#.###}",1.234567));


        }
    }
}
