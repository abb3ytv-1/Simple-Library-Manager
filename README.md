# Simple-Library-Manager

Project Overview

LibraryManager is a simple application designed to manage a collection of books in a library. It uses the Singleton design pattern to ensure that only one instance of the library manager exists throughout the application. This ensures consistent management of the library data and prevents conflicts from multiple instances.

Features

Singleton Pattern Implementation: Ensures a single instance of the LibraryManager.

Book Management: Add, remove, and view books in the library.

Simple Interface: Command-line or basic GUI interface for managing the library.

Thread-Safe Implementation: Safe to use in multithreaded environments (if implemented).

Technologies Used

Language: C#

Framework: .NET Core / .NET 6

Data Storage: In-memory collection (List or Dictionary)

Setup Instructions

Clone the repository:

git clone https://github.com/yourusername/LibraryManager.git


Open the project in Visual Studio (or your preferred IDE).

Build the project to restore dependencies.

Run the project:

For command-line interface:

dotnet run


If there’s a GUI, start it via the IDE or executable.

Usage

The LibraryManager instance is accessed via:

LibraryManager manager = LibraryManager.Instance;


Use the manager instance to add, remove, or view books:

manager.AddBook(new Book("Title", "Author"));
manager.ListBooks();
manager.RemoveBook("Title");

Singleton Pattern Explanation

Why Singleton? Ensures only one LibraryManager exists, maintaining a single source of truth for library data.

Implementation:

Private constructor prevents outside instantiation.

Static property (Instance) provides global access.

Optional: Thread-safe with lazy initialization.

Future Improvements

Persistent storage (database instead of in-memory)

GUI or web interface for easier interaction

Multi-user support with authentication
