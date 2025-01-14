using Microsoft.EntityFrameworkCore;
using ProdutosAPI.Models;

namespace ProdutosAPI.Data;

public class AppDbContext : DbContext
{
    public DbSet<Produto> produtos { get; set; }
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}
