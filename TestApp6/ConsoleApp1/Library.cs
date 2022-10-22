using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    public delegate void NewBookHandler(string message);

    [LibraryValue(LibraryValues.Tiny)]
    internal class Library
    {
        public event NewBookHandler NewBook; 
        private List<Book> Books;
        public Library(List<Book> books)
        {
            Books = books;
        }

        public bool addBook(Book book)
        {
            Books.Add(book);
            NewBook?.Invoke($"New book \"{book.Title}\" in catalogue! Harry UP!!");
            return true;
        }

    }
}
