using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookManager
{
    public class BookManamger : IBookManamger
    {
        static List<Book> myBooks = new List<Book>();
        public void AddBook()
        {
            Book newBook = new Book();
            Console.WriteLine("please add a new book. \n Tittle: ");
            newBook.bookName = Console.ReadLine();
            Console.WriteLine("Author:");
            newBook.bookAuthor = Console.ReadLine();
            Console.WriteLine("Year:");
            newBook.bookYear = int.Parse(Console.ReadLine());
            myBooks.Add(newBook);
            Console.WriteLine($"You add a new book. Name: {newBook.bookName} , Author: {newBook.bookAuthor},Year: {newBook.bookYear}");
        }
        public void ViewAllBooks()
        {
            if (myBooks.Count == 0)
            {
                Console.WriteLine("No book found");
            }
            else 
            { 
                foreach (Book book in myBooks) 
                {
                    Console.WriteLine($"books: {book.bookName}");
                }
            }
        }
        public void FindBook()
        {
            Console.WriteLine("Write the name of book.");
            string bookof = Console.ReadLine();
            Book? book = myBooks.Find(b => b.bookName == bookof);

            if(book is null)
            {
                Console.WriteLine(" This book cant find. Write another book");
            }
            else
            {
                Console.WriteLine($"book is: {book.bookName}, year of the book is: {book.bookYear}, author of the book is: {book.bookAuthor}");
            }
        }
    }
}
