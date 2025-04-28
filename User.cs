using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system
{
    public enum Roles { Librarian, member }; //A private enum outside a class wouldn’t be usable anywhere, so C# disallows it.
                                             //we can use internal or public

    public abstract class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public User(int userId, string userName, string password, string email)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
            Email = email;
           
        }

        public abstract List<Book>  searchBook(string title, List<Book> LibraryBooks);
        public abstract void viewAccount();
        public abstract void changePassword(string NewPassword);

    }

    }

