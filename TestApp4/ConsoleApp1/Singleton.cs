using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Singleton
    {
        private static Singleton _instance;
        private Singleton() {
            //....
            //....
            WriteLine("+++ ctor Singleton" + GetHashCode());
        }
        
        public static Singleton getInstance() { 
        if( _instance == null) _instance = new Singleton();
        return _instance;
        }

    }
}
