
using static System.Console;

namespace andestech.learning2022.krasn.geer
{
    public class Car3
    {
        private string _vendor;
        private int _power;
        private int _mass;

        public string Vendor
        {
            get { return _vendor; }
            private set { _vendor = value; }
        }

        public int Power {
            get { return _power; }
            private set { _power = value; }
        }

        public int Mass { 
        private set { _mass = value; }
        get { return _mass; } 
        }

        public Car3()
        {
            WriteLine("+++ ctor default of Car3.");
        }

        /* public Car3(string vendor, int power, int mass):this()  
         {
             Vendor = vendor;
             Power = power;
             Mass = mass;
         }*/

        public Car3(string Vendor, int Power, int Mass) : this()
        {
            this.Vendor = Vendor;
            this.Power = Power;
            this.Mass = Mass;
        }

        public string getInfo() {
            return $"Car3 {Vendor}, Power: {Power}, Mass: {Mass}.";
        }
    }
}
