namespace EF_Models.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Property
        public ICollection<Category> Category { get; set;}
    }
}
