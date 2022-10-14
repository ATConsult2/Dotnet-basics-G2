using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Program
    {
        static int Summa(int interest, params int[] numbers)
        {
            int summa = 0;
            foreach (int number in numbers) summa += number;
            return summa*interest;
        }

        static void PrintByteArray(byte[] arr) {
            Write("[");
            for (int j = 0; j < arr.Length; j++) Write(arr[j] + ", ");
            Write("\b\b].\n");
        }

        static void Main(string[] args)
        {
            //check command line args
            Write("Command line args: ");
            foreach (string arg in args) 
            { 
                Write(arg + ", "); 
            }
            Write("\b\b.\n");

            // array test
            byte[] arr1 = new byte[10];
            byte[] arr2 = new byte[] { 1, 22, 233, 5, 44, 21, 0, 7, 77, 8 };
            arr1[4] = 222;

            //1 - add random numbers to array
            new Random().NextBytes(arr1);
            PrintByteArray(arr1);

            //2 - - add random numbers to array
            Random random = new Random();
            
            for (int j = 0; j < arr1.Length; j++) arr1[j] = (byte)random.Next(255);
            PrintByteArray(arr1);

            PrintByteArray(arr2);
            WriteLine($"Summa = {Summa(10,new int[] {1,2,3,4,5})}");

        }
    }
}
