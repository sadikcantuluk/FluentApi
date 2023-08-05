using FluentAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Entity
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        //Simple Navigation Property
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public BookDetail BookDetail { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}


