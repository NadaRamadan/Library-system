using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system
{
    public class Book : IBorrowable
    {
        public int BookId {get; set;}
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Book(int bookId, string title, string author, string ISBN, string category, bool isAvailable)
        {
            this.BookId = bookId;
            this.Title = title;
            this.Author = author;   
            this.ISBN = ISBN;
            this.Category = category;   
            this.IsAvailable = isAvailable;
              
        }
        
        public void borrow()
        {
            IsAvailable = false;
        }
       public void returnBook()
        {
            IsAvailable = true;
        }
       public double calculatePenality(int days)
        {
            return days * 1.5;
        }
        
    }
}
