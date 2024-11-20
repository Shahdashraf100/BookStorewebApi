using Microsoft.EntityFrameworkCore;
using projecttyexammmmm.Models;

namespace projecttyexammmmm
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions options) : base(options)
        {
        }//shahd
        public DbSet<Gener> Geners { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Creadetcart> Creadcarts { get; set; }
        public DbSet<Idenitycart> Identitycarts { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
