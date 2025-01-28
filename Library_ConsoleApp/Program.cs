using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_ConsoleApp
{
    internal class Program
    {
        private static Library library = new Library();
        public int booksIncrement = 0;
        static void Main(string[] args)
        {
            ShowMainMenu();
        }

        private static void ShowMainMenu()
        {
            while (true)
            {
                Console.Clear();
                List<string> menu = new List<string>
                {
                     "1. Add Book",
                     "2. Show All Books",
                     "3. Lend Book",
                     "4. Return Book",
                     "5. Quit"
                };

                foreach (string item in menu)
                {
                    Console.WriteLine(item);
                }

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddBook(library);
                        break;
                    case "2":
                        Console.Clear();
                        library.ShowAllBooks();
                        Console.WriteLine("Press any key to return to menu...");
                        Console.ReadKey();
                        break;
                    case "3":
                        LendBook();
                        break;
                    case "4":
                        ReturnBook();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
            }
        }

        private static void AddBook(Library library)
        {
            Console.Clear();
            Console.WriteLine("Book title: ");
            string bookTitle = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(bookTitle))
            {
                Console.WriteLine("Title cannot be empty!");
                System.Threading.Thread.Sleep(1000);
                return;
            }

            Console.WriteLine("Book author: ");
            string bookAuthor = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(bookAuthor))
            {
                Console.WriteLine("Author cannot be empty!");
                System.Threading.Thread.Sleep(1000);
                return;
            }

            library.AddBook(new Book(bookTitle, bookAuthor, false));
            Console.WriteLine($"Book '{bookTitle}' by {bookAuthor} has been added to the library.");
            System.Threading.Thread.Sleep(1000);
        }

        private static void LendBook()
        {
            Console.Clear();
            Console.WriteLine("type title of book you want to lend :");
            string bookToLend = Console.ReadLine();
            library.LendBook(bookToLend);
            ShowMainMenu();
        }
        private static void ReturnBook()
        {
            Console.Clear();
            Console.WriteLine("type title of book you want to return :");
            string bookToReturn = Console.ReadLine();
            library.ReturnBook(bookToReturn);
            ShowMainMenu();
        }
    }
}
