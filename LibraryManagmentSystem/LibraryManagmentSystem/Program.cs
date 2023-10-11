using LibraryManagmentSystem;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Created some books
        Book book1 = new Book("Book 1", "Author 1");
        Book book2 = new Book("Book 2", "Author 2");
        Book book3 = new Book("Book 3", "Author 3");

        // Created some users
        User user1 = new User("User 1", 101);
        User user2 = new User("User 2", 102);

        // Created a library
        Library library = new Library();

        // Added books and users to the library
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        library.AddUser(user1);
        library.AddUser(user2);

        // Displaying the main menu
        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. View Books");
            Console.WriteLine("2. View Users");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        library.DisplayBooks();
                        break;
                    case 2:
                        library.DisplayUsers();
                        break;
                    case 3:
                        Console.Write("Enter your name: ");
                        string userName = Console.ReadLine();
                        Console.Write("Enter the book title to borrow: ");
                        string bookTitleToBorrow = Console.ReadLine();

                        // Finding the user and book by name/title  
                        var user = library.Users.Find(u => u.Name == userName);
                        var bookToBorrow = library.Books.Find(b => b.BookTitle == bookTitleToBorrow);

                        if (user != null && bookToBorrow != null)
                        {
                            user.BorrowBook(bookToBorrow);
                        }
                        else
                        {
                            Console.WriteLine("User or book not found.");
                        }
                        break;
                    case 4:
                        Console.Write("Enter your name: ");
                        string userNameToReturn = Console.ReadLine();
                        Console.Write("Enter the book title to return: ");
                        string bookTitleToReturn = Console.ReadLine();

                        // Finding the the user and book by name/title
                        var userToReturn = library.Users.Find(u => u.Name == userNameToReturn);
                        var bookToReturn = library.Books.Find(b => b.BookTitle == bookTitleToReturn);

                        if (userToReturn != null && bookToReturn != null)
                        {
                            userToReturn.ReturnBook(bookToReturn);
                        }
                        else
                        {
                            Console.WriteLine("User or book not found.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exiting the Library Management System.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number corresponding to your choice.");
            }
        }
    }
}