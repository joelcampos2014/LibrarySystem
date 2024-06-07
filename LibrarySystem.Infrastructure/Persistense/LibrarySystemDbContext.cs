using LibrarySystem.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Infrastructure.Persistense
{
    public class LibrarySystemDbContext : DbContext
    {
        public LibrarySystemDbContext(DbContextOptions<LibrarySystemDbContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
