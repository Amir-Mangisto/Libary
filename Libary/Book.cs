using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary
{
    class Book
    {
        public string name;
        public string writer;
        public int pages;

        public Book(string name, string writer, int pages)
        {
            this.name = name;
            this.writer = writer;
            this.pages = pages;
        }
    }
}
