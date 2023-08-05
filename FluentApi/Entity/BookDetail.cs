using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Entity
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }
        public string ISSN { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
