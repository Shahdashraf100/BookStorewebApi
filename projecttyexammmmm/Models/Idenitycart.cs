using System.ComponentModel.DataAnnotations;

namespace projecttyexammmmm.Models
{
    public class Idenitycart    
    {
        [Key]//kkkl
        //ll
        public int IdentitycartId { get; set; }//klkl,mm
        public DateTime IdentitycartExpireDate { get; set; }
        public Author author { get; set; }
        public int AuthorId {  get; set; }
    }
}
