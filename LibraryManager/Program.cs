using LibraryManager;
using System;

class Program
{
    static void Main()
    {
        var catalog = BookCatalog.GetInstance();
        catalog.AddBook("Harry Potter and the Sorcerer's Stone");
        catalog.AddBook("The Great Gatsby");

        var catalog2 = BookCatalog.GetInstance();
        catalog2.ListBooks();
    }
}
