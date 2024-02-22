using System.Collections;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace bookManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myBookManamger = new BookManamger();
            while (true)
            {

                Console.WriteLine("choose your number");
                Console.WriteLine("1. Add  new book\n 2.Find  books  by name\n 3.View all books");

                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Choose valid number: 1 ,2 or 3");
                    continue;
                }
                switch (number)
                {
                    case 1:
                        myBookManamger.AddBook();
                        break;
                    case 2:
                        myBookManamger.FindBook();
                        break;
                    case 3:
                        myBookManamger.ViewAllBooks();
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}
    
