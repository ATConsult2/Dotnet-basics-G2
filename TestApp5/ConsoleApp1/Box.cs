using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andestech.learning2022.krasn { 

    internal class Box
    {
        public Wire[] Wires { get; private set; }
        public int L { get; private set; }
        public Box(int L)
        {
            this.L = L; 
        Wires = new Wire[L];
        }

        public Box(Wire[] wires)
        {
        Wires = wires;
        L = wires.Length;
        }

        // ... 
        public Wire this[int i] {
            get { return Wires[i]; }
            set { Wires[i] = value; }   
        
        }

}
}
