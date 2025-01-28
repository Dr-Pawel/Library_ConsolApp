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
            Console.Clear();
            List<string> menu =
            [
               "1. Add Book",
               "2. Show All Books",
               "3. Lend Book",
               "4. Return Book",
               "5. Quit"
            ];    
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }
            ChooseOption();
        }
        private static void ChooseOption()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    AddBook(library);
                    ShowMainMenu();
                    break;
                case "2":
                    Console.Clear();
                    library.ShowAllBooks();
                    Console.WriteLine("Press any key to return to menu");
                    Console.ReadKey();
                    ShowMainMenu();
                    break;
                case "3":
                    Console.WriteLine("Lending Book...");
                    break;
                case "4":
                    Console.WriteLine("Returning Book...");
                    break;
                case "5":
                    Console.WriteLine("Quiting...");
                    break;
                default:
                    Console.WriteLine("Wrong input, try again");
                    ChooseOption();
                    break;
            }
        }
        private static void AddBook(Library library)
        {
            Console.Clear();
            Console.WriteLine("book title: ");
            string bookTitle = Console.ReadLine();
            Console.WriteLine("book Author: ");
            string bookAuthor = Console.ReadLine();

            library.AddBook(new Book(bookTitle, bookAuthor, false));
            Console.WriteLine($"Book {bookTitle} by {bookAuthor} has been added to library");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

        }
    }
}
