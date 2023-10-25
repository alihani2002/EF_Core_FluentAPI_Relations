namespace EF_Models.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        //Navigation Property
        public ICollection<Book> Books { get; set; }

    }
}
