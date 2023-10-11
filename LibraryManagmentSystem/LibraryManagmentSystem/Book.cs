using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    public class Book
    {
        public string BookTitle { get; private set; }
        public string BookAuthor { get; private set; }

        public bool IsBookAvailable { get; private set; }

        public Book(string bookTitle, string bookAuthor)
        {
            BookTitle = bookTitle;
            BookAuthor = bookAuthor;
            IsBookAvailable = true;
        }
        public void BookCheckOut()
        {
            if(IsBookAvailable)
            {
                IsBookAvailable = false;
                Console.WriteLine($"Checked out book: {BookTitle} by {BookAuthor}");
            }
            else
            {
                Console.WriteLine($"Sorry the book {BookTitle} has been already CheckedOut");
            }
        }
        public void ReturnBook()
        {
            IsBookAvailable = true;
            Console.WriteLine($"Book {BookTitle}returned by {BookAuthor}");
        }

    }
}
