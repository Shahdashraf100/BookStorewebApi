using System.ComponentModel.DataAnnotations;

namespace projecttyexammmmm.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Authorphone { get; set; }
        public List<Book> books { get; set; }
        public List<Creadetcart> creadcarts { get; set; }
        public Idenitycart identicart { get; set; }
        public int IdentitycartId { get; set; }

    }
}
