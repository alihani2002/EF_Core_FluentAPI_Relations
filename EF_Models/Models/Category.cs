namespace EF_Models.Models
{

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Navigation Property
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public ICollection<Book> Books { get; set; }

    }

}
