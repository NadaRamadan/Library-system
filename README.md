# Library System
This is a simple Library Management System developed using C#. The system allows librarians to manage books in the library, while members can borrow and return books. The system also supports searching for books, viewing user accounts, and imposing penalties for late returns.

# Features
# Librarian Features:

Add and remove books from the library.

Register new members.

Search books by title.

View librarian account details.

Change password.

Impose penalties on members for late book returns.

Member Features:

Search books by title.

Borrow and return books.

View member account details.

Change password.

Common Features:

Books are tracked for availability (borrowed or available).

Penalties are calculated based on the number of days a book is overdue.

# Requirements
.NET Core 5.0 or later

A basic understanding of C# and object-oriented programming (OOP) principles.

Project Structure
Library_system/: Main namespace containing all the logic for the system.

Library_system/Book.cs: Represents a book in the library. It implements the IBorrowable interface and contains properties like Title, Author, ISBN, and Category.

Library_system/User.cs: An abstract class representing a user (either a librarian or a member). It contains properties such as UserId, UserName, Password, and Email.

Library_system/Librarian.cs: Inherits from User and implements librarian-specific operations such as adding/removing books, and managing member registrations.

Library_system/Member.cs: Inherits from User and implements member-specific operations such as borrowing and returning books.

Library_system/Library.cs: Contains the main library logic, including lists of books and members. It also includes methods for showing all books.
