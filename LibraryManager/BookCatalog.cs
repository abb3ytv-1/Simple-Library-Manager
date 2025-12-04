using System;
using System.Collections.Generic;

namespace LibraryManager
{
    public class BookCatalog
    {
        private static BookCatalog _instance;

        private BookCatalog()
        {
            Books = new List<string>();
        }

        public static BookCatalog GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BookCatalog();
            }
            return _instance;
        }

        public List<string> Books { get; private set; }

        public void AddBook(string book)
        {
            Books.Add(book);
            Console.WriteLine($"Book '{book}' added.");
        }

        public void ListBooks()
        {
            Console.WriteLine("Books in catalog:");
            foreach (var book in Books)
            {
                Console.WriteLine($"- {book}");
            }
        }
    }
}
