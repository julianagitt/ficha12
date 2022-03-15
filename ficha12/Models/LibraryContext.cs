using Microsoft.EntityFrameworkCore;

namespace ficha12.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet <Book> Books { get; set; }
        public DbSet<Publisher> Publisher { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options)
    : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=library;" + "user=root;password=juliana1995.");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Publisher>(entity =>
            { 
                entity.HasKey(e=> e.Id);
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Book>(entity=>
            {
                entity.HasKey(e => e.ISBN);
                entity.Property(e => e.Title).IsRequired();
                entity.HasOne(d => d.Publisher);
            });

        }
    }

}
