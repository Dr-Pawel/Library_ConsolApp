using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_ConsoleApp
{
    internal class Library
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void LendBook(string title)
        {
            foreach (Book book in books)
            {
                if(book.title.ToLower() == title.ToLower())
                {
                    book.isLend = true;
                }
            }
        }

        public void ReturnBook(string title)
        {
            foreach (Book book in books)
            {
                if (book.title.ToLower() == title.ToLower())
                {
                    book.isLend = false;
                }
            }
        }

        public void ShowAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.title} by {book.author} - is currently lend ? : {book.isLend}");
            }
        }

        public void FindBook(string title)
        {
            foreach (Book book in books)
            {
                if (book.title.ToLower() == title.ToLower())
                {
                    Console.WriteLine($"{book.title} by {book.author} - is currently lend ? : {book.isLend}");
                }
            }
        }

    }
}
