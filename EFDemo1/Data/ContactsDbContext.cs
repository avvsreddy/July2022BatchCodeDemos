using EFDemo1.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFDemo1.Data
{
    public class ContactsDbContext : DbContext
    {

        // Map the connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ContactsDb2022EF;Integrated Security=True");
            //optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }
        // Map the entity class to tables
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
