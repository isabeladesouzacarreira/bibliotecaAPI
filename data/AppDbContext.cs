using Microsoft.EntityFrameworkCore;
using bibliotecaAPI.Models;

namespace bibliotecaAPI.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        } 
        public DbSet<livro> Livros { get; set; }
    }
}