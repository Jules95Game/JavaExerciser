using JavaExerciser.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace JavaExerciser.DataAccess;

public class DataContext : DbContext
{
    public DbSet<Problem> Problems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=JavaProblemDB;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.Entity<Problem>().HasData(
            new()
            {
                Id = 1,
                Name = "FindPrimeNumbers"
            },
            new()
            {
                Id = 2,
                Name = "FormatStrings"
            });
}
