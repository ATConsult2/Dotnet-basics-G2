
using static System.Console;

namespace andestech.learning2022.krasn.geer
{
    public class Car2
    {
        private string _vendor;
        private int _power;
        private int _mass;

        public string Vendor
        {
            get { return _vendor; }
            set { _vendor = value; }
        }

        public int Power {
            get { return _power; }
            set { _power = value; }
        }

        public int Mass { 
        set { _mass = value; }
        get { return _mass; } 
        }

        public Car2()
        {
            WriteLine("+++ ctor of Car2.");
        }

        public string getInfo() {
            return $"Car2 {Vendor}, Power: {Power}, Mass: {Mass}.";
        }
    }
}
