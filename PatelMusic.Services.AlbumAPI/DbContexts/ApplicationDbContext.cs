using Microsoft.EntityFrameworkCore;
using PatelMusic.Services.AlbumAPI.Models;

namespace PatelMusic.Services.AlbumAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //public ApplicationDbContext()
        {
        }

        public DbSet<Album> Albums { get; set; }
    }
}