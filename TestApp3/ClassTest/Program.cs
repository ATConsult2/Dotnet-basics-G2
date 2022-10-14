
using andestech.learning2022.krasn.geer;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car0;
            Car car = new Car();
            //1
            car.Power = 200;
            car.Mass = 1500;
            car.Vendor = "GAZ";
            WriteLine(car.getInfo());
            //2
            Car car2 = new Car{ Vendor = "Vaz", Power = 120, Mass = 1200 };
            WriteLine(car2.getInfo());

            //---------------
            Car2 car22 = new Car2 { Vendor = "BMW", Power = 240, Mass = 1700 };
            WriteLine(car22.getInfo());

            //----------------
            Car3 car33 = new Car3("UAZ",120,1800);
            WriteLine(car33.getInfo());
            car33 = new Car3("KIA", 120, 1350);
            WriteLine(car33.getInfo());
            //------------------
            Car4 car44 = new Car4("Audi", 130, 1600);
            WriteLine(car44.getInfo());
            car44 = new Car4("BMW", 230, 1800);
            //WriteLine(car44.getInfo());
            WriteLine(car44);
            //--------------------------
            // Car4.Metadata = "GGGG"; // readonly static field!!
            // Car4.TestStend = "www"; // const!!!

            //car33.Power = 111;

            //---- STRUCT & CLASS REF TEST -----
            WriteLine("------------ STRUCT CLASS REF TEST --------");

            BoxClass bclass1 = new BoxClass(10);
            BoxClass bclass2 = bclass1;
            bclass2.A = 200;
            WriteLine(bclass2); WriteLine(bclass1);

            BoxStruct bs1 = new BoxStruct(10);
            BoxStruct bs2 = bs1;
            bs2.A = 200;
            WriteLine(bs1); WriteLine(bs2);









            new Car();

        }
    }
}
