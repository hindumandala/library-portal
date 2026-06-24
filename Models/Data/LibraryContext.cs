using Microsoft.EntityFrameworkCore;
using LibraryPortal.Models;

namespace LibraryPortal.Data;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
}