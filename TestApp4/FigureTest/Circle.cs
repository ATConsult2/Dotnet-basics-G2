using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andestech.learning2022.krasn.geom
{
    internal class Circle : Figure
    {
        public int R { get; set; }

        public override double perimeter()
        {
            return 2 * Math.PI * R;
        }

        public override double square()
        {
            return Math.PI * R * R;
        }

        public override string ToString()
        {
            return $"Circle R={R}, x={PointXY.X} y={PointXY.Y}, " +
                   $"S={square():#.###}, P={perimeter():#.###}";
        }
    }
}
