using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    public class User
    {
        public string Name { get; private set; }
        public int UserId { get; private set; }

        public User(string name, int userId)
        {
          Name = name;
          UserId = userId;
        }
        public void BorrowBook(Book book )
        {
            if(book.IsBookAvailable)
            {
                book.BookCheckOut();
                Console.WriteLine($"{Name} borrowed{book.BookTitle}");
            }
            else
            {
                Console.WriteLine($"{Name} cannot borrow{book.BookTitle} as it's already Checked Out!");
            }

        }

        public void ReturnBook(Book book)
        {
            if (!book.IsBookAvailable)
            {
                book.ReturnBook();
                Console.WriteLine($"{Name} returned {book.BookTitle}.");
            }
            else
            {
                Console.WriteLine($"{Name} cannot return {book.BookTitle} as it's already available.");
            }
        }


    }
}
