using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Bookmgmt
    {
        private List<Library> library;

        public Bookmgmt()
        {
            library = new List<Library>()
            {
                new Library() {BookId=1,Title="mm1",Author="Manish",Genre="first edition",IsAvailable=true},
                new Library() {BookId=2,Title="mm2",Author="RDSHARMA",Genre="Second edition",IsAvailable=false},
                new Library() {BookId=3,Title="mm3",Author="Mmlhotra",Genre="3rd edition",IsAvailable=false},
                new Library() {BookId=4,Title="mm4",Author="keshav Prasad",Genre="2nd edition",IsAvailable=true}
            };
        }

        public void printList()
        {
            foreach (Library book in library)
            {
                Console.WriteLine("Book ID: " + book.BookId);
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Genre: " + book.Genre);
                Console.WriteLine("Is Available: " + book.IsAvailable);
                Console.WriteLine();
            }
        }

        public void SearchBookbyID()
        {
            Console.WriteLine("Enter Book ID:");
            int bk = int.Parse(Console.ReadLine());

            Library book = library.FirstOrDefault(b => b.BookId == bk);
            if (book != null)
            {
                Console.WriteLine("Book is available");
            }
            else
            {
                Console.WriteLine("Book is not available");
            }
        }

        public void SearchBookbyTitle()
        {
            Console.WriteLine("Enter Book Title:");
            string bk = Console.ReadLine();

            Library book = library.FirstOrDefault(b => b.Title.Equals(bk, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                Console.WriteLine("Book is available");
            }
            else
            {
                Console.WriteLine("Book is not available");
            }
        }

        public void AddBook(Library newBook)
        {
            library.Add(newBook);
            Console.WriteLine("Book added successfully.");
        }
    }
}
