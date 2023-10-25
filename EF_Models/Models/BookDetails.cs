namespace EF_Models.Models
{
    public class BookDetails
    {
        public int Id { get; set; }
        public int NumberOfPage { get; set; }
        public int NumberOfChapter { get; set; }
        public float Weight { get; set; }

        //Navigation Property
        public ICollection<Book> Books { get; set;}
    }
}
