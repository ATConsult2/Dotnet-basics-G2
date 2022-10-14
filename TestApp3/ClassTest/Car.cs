
using static System.Console;

namespace andestech.learning2022.krasn.geer
{
    public class Car
    {
        public string Vendor;
        public int Power;
        public int Mass;

        public Car()
        {
            WriteLine("+++ ctor of Car.");
        }

        public string getInfo() {
            return $"Car {Vendor}, Power: {Power}, Mass: {Mass}.";
        }
    }
}
