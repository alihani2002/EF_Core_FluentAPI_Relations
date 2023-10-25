namespace EF_Models.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public float Price { get; set; }

        //Navigation Property
        public int BookDetailsId { get; set; }
        public BookDetails BookDetails { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<BookAuthor> BookAuthor { get; set;}

    }
}
