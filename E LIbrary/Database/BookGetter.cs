using E_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Library.Database {
    public class BookGetter {
        public List<Book> books { get; set; }

        public BookGetter() {
            var authorGetter = new AuthorGetter();

            books = new List<Book>() {
                new Book() { Id = 1,    Author = authorGetter.GetAuthorById(1),     Title = "Don Quixote",                   Description = "Dummy description for Don Quixote",                      Image = "DonQuixote.jpg" },
                new Book() { Id = 2,    Author = authorGetter.GetAuthorById(2),     Title = "Hamlet",                        Description = "Dummy description for Hamlet",                           Image = "Hamlet.jpg" },
                new Book() { Id = 3,    Author = authorGetter.GetAuthorById(3),     Title = "In Search Of Lost Time",        Description = "Dummy description for In Search Of Lost Time",           Image = "InSearchOfLostTime.jpg" },
                new Book() { Id = 4,    Author = authorGetter.GetAuthorById(4),     Title = "Moby Dick",                     Description = "Dummy description for Moby Dick",                        Image = "MobyDick.jpg" },
                new Book() { Id = 5,    Author = authorGetter.GetAuthorById(5),     Title = "One Hundred Years Of Solitude", Description = "Dummy description for One Hundred Years Of Solitude",    Image = "OneHundredYearsOfSolitude.jpg" },
                new Book() { Id = 6,    Author = authorGetter.GetAuthorById(6),     Title = "The Divine Comedy",             Description = "Dummy description for The Divine Comedy",                Image = "TheDivineComedy.jpg" },
                new Book() { Id = 7,    Author = authorGetter.GetAuthorById(7),     Title = "The Great Gatsby",              Description = "Dummy description for The Great Gatsby",                 Image = "TheGreatGatsby.jpg" },
                new Book() { Id = 8,    Author = authorGetter.GetAuthorById(8),     Title = "The Odyssey",                   Description = "Dummy description for The Odyssey",                      Image = "TheOdyssey.jpg" },
                new Book() { Id = 9,    Author = authorGetter.GetAuthorById(9),     Title = "Ulysses",                       Description = "Dummy description for Ulysses",                          Image = "Ulysses.jpg" },
                new Book() { Id = 10,   Author = authorGetter.GetAuthorById(10),    Title = "War And Peace",                 Description = "Dummy description for War And Peace",                    Image = "WarAndPeace.jpg" },
            };
        }

        public List<Book> GetBooks(int page, string sort) {
            // Page not used rn

            var list = new List<Book>();

            switch (sort) {
                case "Title":
                    list = new List<Book>(books);
                    list.Sort((b1, b2) => {
                        return (b1.Title.CompareTo(b2.Title));
                    });
                    break;
                case "Author":
                    list = new List<Book>(books);
                    list.Sort((b1, b2) => {
                        return (b1.Author.Name.CompareTo(b2.Author.Name));
                    });
                    break;
                default: break;
            }

            return list;
        }

        public List<Book> GetBooksByAuthor(int? id) {
            var list = new List<Book>();
            foreach (Book book in books) {
                if (book.Author.Id == id) list.Add(book);
            }
            return list;
        }

        public List<Book> GetBooksFeatured() {
            var list = new List<Book>();
            list.Add(books[5]);
            list.Add(books[6]);
            list.Add(books[8]);
            return list;
        }

        public Book GetBookById(int? _id) {
            int id = _id ?? -1;
            if ((1 <= id) && (id <= books.Count)) {
                return books[id - 1];
            }
            return null;
        }
    }
}