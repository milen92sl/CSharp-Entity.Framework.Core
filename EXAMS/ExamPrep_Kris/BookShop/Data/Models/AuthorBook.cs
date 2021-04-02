using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    public class AuthorBook
    {
        [ForeignKey(nameof(Author))]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        [ForeignKey(nameof(Book))]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}

//•	AuthorId - integer, Primary Key, Foreign key (required)
//•	Author -  Author
//•	BookId - integer, Primary Key, Foreign key (required)
//•	Book - Book
