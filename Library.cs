using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Member> Members { get; set; } = new List<Member>();

        public void ShowAllBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"{book.BookId}: {book.Title} by {book.Author} - {(book.IsAvailable ? "Available" : "Borrowed")}");
            }
        }
    }

}
