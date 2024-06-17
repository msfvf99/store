﻿using System;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 0201038013", "D.Knuth", "Art Of Programming, Vol. 1", 
                "This volume begins with basic programming concepts and technique",
                12.5m),

            new Book(2, "ISBN 0201485672", "M. Fowler", "Refactoring",
                "As the application of object technology--particularly the Java",
                12.45m),

            new Book(3, "ISBN 0131101633", "B. Kernighan, D. Ritchie", "C Programming Language",
                "Known as the bible of C, this classic bestseller introduces the",
                14.98m),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                    || book.Title.Contains(query))
                        .ToArray();
        }

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}
