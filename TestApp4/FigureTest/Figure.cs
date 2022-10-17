using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andestech.learning2022.krasn.geom
{
    internal abstract class Figure
    {
        public Point PointXY { get; set; }
        abstract public double square();
        abstract public double perimeter();

    }
}
