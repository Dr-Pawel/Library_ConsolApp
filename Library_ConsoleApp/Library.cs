using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_ConsoleApp
{
    internal class Library
    {
        public List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void LendBook(string title)
        {
            bool found = false; 

            foreach (Book book in books)
            {
                if (book.title.ToLower() == title.ToLower())
                {
                    if (!book.isLend)
                    {
                        book.isLend = true;
                        Console.WriteLine($"{title} is now on loan.");
                    }
                    else
                    {
                        Console.WriteLine($"{title} is already on loan.");
                    }
                    found = true; 
                    break; 
                }
            }

            if (!found)
            {
                Console.WriteLine($"{title} couldn't be found in the library.");
            }
        }

        public void ReturnBook(string title)
        {
            bool found = false;

            foreach (Book book in books)
            {
                if (book.title.ToLower() == title.ToLower())
                {
                    if (book.isLend)
                    {
                        book.isLend = false;
                        Console.WriteLine($"{title} has been returned.");
                    }
                    else
                    {
                        Console.WriteLine($"{title} was not on loan.");
                    }
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"{title} couldn't be found in the library.");
            }
        }

        public void ShowAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"{book}");
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
