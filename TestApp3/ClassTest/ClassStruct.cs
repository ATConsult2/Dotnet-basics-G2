using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andestech.learning2022.krasn
{
    internal class BoxClass
    {
       public int A { get; set; }

       public BoxClass(int a)
        {
            A = a;
        }

        public override string ToString()
        {
            return $"Box Class, A={A}";
        }
    }

    public struct BoxStruct
    {
        public int A { get; set; }

        public BoxStruct(int a)
        {
            A = a;
        }

        public override string ToString()
        {
            return $"Box Struct, A={A}";
        }

    }

}
