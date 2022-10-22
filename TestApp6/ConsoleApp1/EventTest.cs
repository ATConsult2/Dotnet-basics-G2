using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class EventTest
    {
        static public void Main2(string[] args)
        {
            // Program.Main2(args); // Delegate and Calc test

            Book book1 = new Book() { Author = "Артур Конан-Дойль", Title = "Затерянный мир" };
            Book book2 = new Book() { Author = "Alexei Tolstoi", Title = "Aelita" };

            Library lib = new Library(new List<Book>());

            NewBookHandler S1 = mess => WriteLine("S1: " + mess);
            NewBookHandler S2 = mess => WriteLine("S2: " + mess);

            lib.NewBook += S1;
            lib.addBook(book1);
            
            lib.NewBook += S2;
            lib.addBook(book2);




        }
    }
}
