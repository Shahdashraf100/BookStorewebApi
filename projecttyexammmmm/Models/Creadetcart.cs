using System.ComponentModel.DataAnnotations;

namespace projecttyexammmmm.Models
{
    public class Creadetcart
    {
        [Key]
        public int CreadcartId { get; set; }
        public string CreadcartName { get; set; }
        public Author author { get; set; }
        public int AuthorId { get; set; }
    }
}
