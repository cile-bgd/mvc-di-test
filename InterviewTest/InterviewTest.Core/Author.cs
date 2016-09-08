using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest.Core
{
    public class Author
    {
        public Author(string first, string last, int age)
        {
            FirstName = first;
            LastName = last;
            Age = age;
        }

        public Author()
        {

        }


        [Key]
        public virtual Guid Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int Age { get; set; }
    }
}
