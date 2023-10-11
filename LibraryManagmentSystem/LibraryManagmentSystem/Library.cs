using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    
    public class Library
    {
        // Properties
        public List<Book> Books { get; } = new List<Book>();
        public List<User> Users { get; } = new List<User>();

        // Method to add book to the List Books
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        // Method to add book to the List Users
        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in the library:");
            foreach (var book in Books)
            {
                Console.WriteLine($"{book.BookTitle} by {book.BookAuthor} - {(book.IsBookAvailable ? "Available" : "Checked Out")}");
            }
        }

        public void DisplayUsers()
        {
            Console.WriteLine("Library users:");
            foreach (var user in Users)
            {
                Console.WriteLine($"{user.Name} (ID: {user.UserId})");
            }
        }
    }
}
