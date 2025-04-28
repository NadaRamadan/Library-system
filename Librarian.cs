using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Library_system
{
    public class Librarian : User
    {
        private List<Book> Books = new List<Book>();
        public Librarian(int userId, string userName, string password, string email) : base(userId, userName, password, email)
        {

        }
        public override List<Book> searchBook(string title, List<Book> LibraryBooks)
        {
            return LibraryBooks.FindAll(b => b.Title.Contains(title));  
        }
        public override void viewAccount()
        {
            Console.WriteLine($"Librarian: {UserName}, ID: {UserId}");
        }

        public override void changePassword(string NewPassword)
        {
            Password = NewPassword;
            Console.WriteLine("Password updated successfully");
        }
        public void Addbook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Book '{book.Title}' by {book.Author} has been added to the library");

        }
        public void Removebook(int bookId)
        {
            var book = Books.FirstOrDefault(b => b.BookId == bookId);
            if (book != null)

            {
                Books.Remove(book);
                Console.WriteLine($"Book '{book.Title}' by {book.Author} has been added to the library");
            }
            else
            {

                Console.WriteLine("book is not found");
            }

        }
        public void AddMembers (Member member, List<Member> members)
        {
            members.Add(member);
            Console.WriteLine($"Member '{member.UserName}' registered.");

        }

        public void ImposePenalty(Member member, double amount)
        {
            Console.WriteLine($"Penalty of ${amount} imposed on {member.UserName}.");
        }
    }
}
  

    

    