using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest.Core
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        void Add(Book book);
        IEnumerable<Author> GetAuthors();
        void Add(Author author);
    }
}
