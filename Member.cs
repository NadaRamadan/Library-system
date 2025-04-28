using Library_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library_system
{
    public class Member : User
    {
        List<Book> BorrowedBooks = new List<Book>();
        public Member(int userId, string userName, string password, string email) :
           base(userId, userName, password, email)
        {
        }
        public override List<Book> searchBook(string title, List<Book> LibraryBooks)
        {
            return LibraryBooks.FindAll(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
        }
        public override void viewAccount()
        {
            Console.WriteLine($"Member: {UserName}, ID: {UserId}");
            Console.WriteLine("Borrowed Books:");
            foreach (var book in BorrowedBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        public override void changePassword(string NewPassword)
        {
            Password = NewPassword;
            Console.WriteLine("Password updated successfully");
        }
        public void BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                book.borrow();

                BorrowedBooks.Add(book);
                Console.WriteLine($"Book '{book.Title}' borrowed.");

            }
            else
            {
                Console.WriteLine("Book is currently unavailable.");

            }
        }
        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                book.returnBook();
                BorrowedBooks.Remove(book);
                Console.WriteLine("Book '{book.title}' returned" );
            }
        }

    }
    }
