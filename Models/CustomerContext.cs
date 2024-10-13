using Microsoft.EntityFrameworkCore;

namespace CarQuest.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        { }

        public DbSet<Customers> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>().HasData(
                new Customers { ID = 1, FirstName = "John", LastName = "Doe", Email = "abc@xyz.edu" },
                new Customers { ID = 2, FirstName = "James", LastName = "Bond" },
                new Customers { ID = 3, FirstName = "Tom", LastName = "Cruise" },
                new Customers { ID = 4, FirstName = "Johnny", LastName = "Depp" },
                new Customers { ID = 5, FirstName = "Leo", LastName = "Blade" },
                new Customers { ID = 6, FirstName = "Emma", LastName = "Stone", Email = "emma@stone.com" },
                new Customers { ID = 7, FirstName = "Chris", LastName = "Evans", Email = "chris@evans.com" },
                new Customers { ID = 8, FirstName = "Scarlett", LastName = "Johansson", Email = "scarlett@johansson.com" },
                new Customers { ID = 9, FirstName = "Robert", LastName = "Downey Jr.", Email = "robert@downey.com" },
                new Customers { ID = 10, FirstName = "Natalie", LastName = "Portman", Email = "natalie@portman.com" },
                new Customers { ID = 11, FirstName = "Harrison", LastName = "Ford", Email = "harrison@ford.com" },
                new Customers { ID = 12, FirstName = "Denzel", LastName = "Washington", Email = "denzel@washington.com" },
                new Customers { ID = 13, FirstName = "Leonardo", LastName = "DiCaprio", Email = "leonardo@dicaprio.com" },
                new Customers { ID = 14, FirstName = "Angelina", LastName = "Jolie", Email = "angelina@jolie.com" },
                new Customers { ID = 15, FirstName = "Brad", LastName = "Pitt", Email = "brad@pitt.com" }
            );
        }
    }
}
