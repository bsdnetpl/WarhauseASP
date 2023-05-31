using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WarhauseASP.Shared;


namespace WarhauseASP.Server.DB
{
    public class ConnectionDB : IdentityDbContext
    {
        public ConnectionDB(DbContextOptions<ConnectionDB> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Invoce> Invoces { get; set; }
        public DbSet<InvoceAll> invoceAlls { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<FileAuthKey> fileAuthKeys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().Property(x => x.Role).IsRequired();
            modelBuilder.Entity<User>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<State>().HasIndex(x => x.EAN).IsUnique();
            modelBuilder.Entity<State>().HasIndex(x => x.Name).IsUnique();

        }
    }
}
