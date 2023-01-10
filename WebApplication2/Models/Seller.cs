namespace WebApplication2.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public virtual ICollection<Book>? Books { get; set; }
    }
}
