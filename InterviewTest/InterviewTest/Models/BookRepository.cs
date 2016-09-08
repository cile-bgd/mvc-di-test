using InterviewTest.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InterviewTest.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Author author)
        {
            _dbContext.Authors.Add(author);
        }

        public void Add(Book book)
        {
            _dbContext.Books.Add(book);
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _dbContext.Authors;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _dbContext.Books;
        }
    }
}