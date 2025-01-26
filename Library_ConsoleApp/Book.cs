using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_ConsoleApp
{
    internal class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public bool isLend { get; set; }

        public Book(string title, string author, bool isLend)
        {
            this.author = author;
            this.title = title;
            this.isLend = isLend;
        }


    }
}
