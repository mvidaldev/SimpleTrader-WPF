using Microsoft.EntityFrameworkCore;
using SimpleTrader.Domain.Models;

namespace SimpleTrader.EntityFramework;

public class SimpleTraderDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Stock> Stocks { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<AssetTransaction> AssetTransactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AssetTransaction>()
            .OwnsOne(a => a.Stock);


        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=SimpleTrader-dev;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
    }
}