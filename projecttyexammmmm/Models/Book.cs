using System.ComponentModel.DataAnnotations;

namespace projecttyexammmmm.Models
{
    public class Book
    {//uppp
        [Key]
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public DateTime BookPublishedDate { get; set; }
        public List<Author> authors { get; set; }
        public List<Gener> geners { get; set; }
    }
}
