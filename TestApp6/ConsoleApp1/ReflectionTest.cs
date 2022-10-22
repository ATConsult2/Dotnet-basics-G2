//#define DEBUG2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Reflection;
using System.Diagnostics;

namespace andestech.learning2022.krasn
{
    internal class ReflectionTest
    {
        static public void Main2(string[] args) {
            //  DelegateTest.Main2(args);
            //  EventTest.Main2(args);
            Type type = typeof(Book);
            PropertyInfo[] props =
                type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in props) 
            WriteLine(prop.Name + " ----- " + prop.Module + " --- " +
            prop.PropertyType);

            FieldInfo f1 = type.GetField("_id", BindingFlags.NonPublic | BindingFlags.Instance);
            Book book2 = new Book() { Author = "Alexei Tolstoi", Title = "Aelita" };
            WriteLine("Id:" + book2.Id);
            f1.SetValue(book2, 111222);
            WriteLine("Id:" + book2.Id);
            // m1.InvokeMethod(book2, new object[]{arg1, arg2, ...})


            // Assembly asm = Assembly.Load(
            //    @"C:\Users\sand\projects\Krasnoyarsk-2022\Dotnet-basics-G2\TestApp6\ConsoleApp1\bin\Debug\ConsoleApp1.exe");
            // Type type2 = asm.GetType("andestech.learning2022.krasn.Book");
            // Book b2 =  Activator.CreateInstance(type2)

            F1();
            F2();

            Type typeLib = typeof(Library);
            LibraryValueAttribute attr = typeLib.GetCustomAttribute(typeof(LibraryValueAttribute))
                as LibraryValueAttribute;
            WriteLine("LibValue: " + attr.LibraryValue);

        }

        [Conditional("DEBUG1")]
        static void F1() => WriteLine("F1 +++");

        //[Conditional("DEBUG1")]
        [Conditional("DEBUG2")]
        static void F2() => WriteLine("F2 +++");
    }
}
