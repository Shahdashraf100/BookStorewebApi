using System.ComponentModel.DataAnnotations;

namespace projecttyexammmmm.Models
{
    public class Gener
    {
        [Key]
        public int GenerId { get; set; }
        public string GenerName { get; set; }
        public List<Book> books { get; set; }
    }
}
