namespace WebApplication2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;

        public int AuthorId { get; set; }
        public virtual Author? Author { get; set; }

        public virtual ICollection<Seller>? Sellers { get; set; }
    }
}
