using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.krasn
{
    internal class Book
    {
        private int _id;
        public string Title { get; set; }   
        public string Author { get; set; }

        public int Id { get => _id; }
    }
}
