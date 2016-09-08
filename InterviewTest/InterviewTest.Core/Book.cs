using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest.Core
{
    public class Book
    {
        public Book(string title, Author author, DateTime releaseDate)
        {
            Title = title;
            ReleaseDate = releaseDate;
            Author = new Author(author.FirstName, author.LastName, author.Age);
        }

        public Book()
        {

        }

        [Key]
        public virtual Guid Id { get; set; }
        public virtual string Title { get; set; }
        public virtual Author Author { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
    }
}
