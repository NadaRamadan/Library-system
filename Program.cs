using System;
using System.Collections.Generic;

namespace Library_system
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the library, librarian, and members
            Library library = new Library();

            Librarian librarian = new Librarian(1, "Librarian1", "password123", "librarian@example.com");
            Member member1 = new Member(2, "Member1", "password123", "member1@example.com");
            Member member2 = new Member(3, "Member2", "password123", "member2@example.com");

            // Add books to the library with the isAvailable argument
            librarian.Addbook(new Book(101, "The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", "Classic", true));
            librarian.Addbook(new Book(102, "1984", "George Orwell", "9780451524935", "Dystopian", true));
            librarian.Addbook(new Book(103, "To Kill a Mockingbird", "Harper Lee", "9780061120084", "Fiction", true));

            // Show all books in the library
            Console.WriteLine("All books in the library:");
            library.ShowAllBooks();
            Console.WriteLine();

            // Member searches for a book
            Console.WriteLine("Searching for books with '1984' in the title:");
            var searchResults = member1.searchBook("1984", library.Books);
            foreach (var book in searchResults)
            {
                Console.WriteLine($"{book.BookId}: {book.Title} by {book.Author} - {(book.IsAvailable ? "Available" : "Borrowed")}");
            }
            Console.WriteLine();

            // Member borrows a book
            var bookToBorrow = library.Books.Find(b => b.BookId == 102);
            member1.BorrowBook(bookToBorrow);

            // Show borrowed books
            Console.WriteLine("\nMember1's account details:");
            member1.viewAccount();
            Console.WriteLine();

            // Member tries to borrow a book that's already borrowed
            var bookToBorrowAgain = library.Books.Find(b => b.BookId == 102);
            member2.BorrowBook(bookToBorrowAgain); // This should say "Book is currently unavailable."

            // Member returns a book
            member1.ReturnBook(bookToBorrow);

            // Show Member's account again after returning a book
            Console.WriteLine("\nMember1's account details after returning the book:");
            member1.viewAccount();
            Console.WriteLine();

            // Librarian imposes a penalty
            librarian.ImposePenalty(member1, 5.0);
        }
    }
}
