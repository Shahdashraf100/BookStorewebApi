using System.ComponentModel.DataAnnotations;

namespace projecttyexammmmm.Models
{
    public class Idenitycart    
    {
        [Key]//kkk
        public int IdentitycartId { get; set; }
        public DateTime IdentitycartExpireDate { get; set; }
        public Author author { get; set; }
        public int AuthorId {  get; set; }
    }
}
