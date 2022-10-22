using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    enum LibraryValues { 
    Tiny,
    Small,
    Medium,
    Large,
    Hume
    }

    [AttributeUsage( AttributeTargets.Class | AttributeTargets.Struct)] 
    internal class LibraryValueAttribute : Attribute
    {
        private LibraryValues value = LibraryValues.Medium;
        public LibraryValues  LibraryValue { get { return value; } }
        public LibraryValueAttribute(LibraryValues value)
        {
            this.value = value;
        }
        public LibraryValueAttribute() { }
    }
}
