using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace andestech.learning2022.krasn
{
    internal class Container<T>
    {
        public T Data {get; private set;}
        public Container(T data)
        {
            Data = data;
        }   
    }
}
