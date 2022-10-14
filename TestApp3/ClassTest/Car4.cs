
using static System.Console;

namespace andestech.learning2022.krasn.geer
{
    public class Car4
    {
        
        public string Vendor { get; }
        public int Power { get;}
        public int Mass { get; }
        
        public Car4()
        {
            WriteLine("+++ ctor default of Car4, id:" + this.GetHashCode());
        }

        /* public Car3(string vendor, int power, int mass):this()  
         {
             Vendor = vendor;
             Power = power;
             Mass = mass;
         }*/

        public Car4(string Vendor, int Power, int Mass) : this()
        {
            this.Vendor = Vendor;
            this.Power = Power;
            this.Mass = Mass;
        }

        public string getInfo() {
           // Mass = 0;
            return $"Car4 {Vendor}, Power: {Power}, Mass: {Mass}.";
            
        }
    }
}
