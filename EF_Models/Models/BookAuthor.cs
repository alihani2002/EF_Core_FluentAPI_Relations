using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class BookAuthor
    {
        public int BookAuthorID { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int AuthorID { get; set; }
        public Author Author { get; set; }

    }
}
